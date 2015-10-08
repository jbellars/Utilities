using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EMSG.Eds;

namespace Utilities
{
    /// <summary>
    /// Description: Methods compiled from my various projects that I use all the time.
    /// Author: Justin Bellars
    /// </summary>
    class HelperMethods
    {
        #region Conversion / Parsing Methods

        /// <summary>
        /// Determine if a string that should be containing a float is numeric.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        /// <summary>
        /// Parse a numeric string and extract an integer.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int ParseIntFromString(string s)
        {
            return IsNumeric(s) ? int.Parse(s) : 0;
        }

        public static int? ParseStringAsIntOrNull(string s)
        {
            try
            {
                return int.Parse(s);
            }
            catch
            {
                return null;
            }
        }

        public static double? ParseStringAsDoubleOrNull(string s)
        {
            try
            {
                return double.Parse(s);
            }
            catch
            {
                return null;
            }
        }

        public static bool AssertBool(bool b)
        {
            try
            {
                return b;
            }
            catch
            {
                return false;
            }
        }

        public static int ConvertStringToInt32OrZero(string s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch
            {
                return 0;
            }
        }

        public static int ConvertNullableToInt32OrZero(int? i)
        {
            try
            {
                return Convert.ToInt32(i);
            }
            catch
            {
                return 0;
            }
        }

        public static double ConvertNullableToDoubleOrZero(string s)
        {
            try
            {
                return Convert.ToDouble(s);
            }
            catch
            {
                return 0.00;
            }
        }

        public static DateTime ConvertNullableToDateTime(DateTime? dt)
        {
            try
            {
                return Convert.ToDateTime(dt);
            }
            catch
            {
                return new DateTime();
            }
        
        }

        #endregion Conversion / Parsing Methods

        #region Aesthetics

        /// <summary>
        /// Some data from PeopleSoft is not human-readable. Make it so, number one!
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string FixStringWithoutWhiteSpaceFollowingComma(string s)
        {
            return Regex.Replace(s, ",", ", ");
        }

        /// <summary>
        /// Turn strings like 555\555=1234 into 5555551234 and use masks on presentation level to beautify.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string FixEdsPhoneNumber(string s)
        {
            return Regex.Replace(s, @"[\\\/\-]", "");
        }

        public static readonly string StandardPhoneNumberPattern = @"\b([0-9]{3})([0-9]{3})([0-9]{4})\b";
        public static readonly string StandardPhoneNumberReplacement = @"($1) $2-$3";

        /// <summary>
        /// Takes a numeric sequence of 10 digits and formats it as a standard (###) ###-#### phone number.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string FormatStandardPhoneNumber(string input)
        {
            Regex rgx = new Regex(StandardPhoneNumberPattern);
            return rgx.Replace(input, StandardPhoneNumberReplacement);
        }

        #endregion Aesthetics

        #region Email Methods

        private static SmtpClient _client;

        /// <summary>
        /// Gets the host name of the smtp server from the configuration file (web.config or app.config)
        /// </summary>
        private static string SmtpHost
        {
            get { return System.Configuration.ConfigurationSettings.AppSettings.Get("SMTPHost"); }
        }

        /// <summary>
        /// Gets the EmailPort value from the configuration file (web.config or app.config)
        /// </summary>
        private static int Port
        {
            get { return int.Parse(System.Configuration.ConfigurationSettings.AppSettings.Get("EmailPort")); }
        }

        /// <summary>
        /// Gets the designated Error Recipient's email value from the configuration file (web.config or app.config)
        /// </summary>
        public static string ErrorRecipient
        {
            get { return System.Configuration.ConfigurationSettings.AppSettings.Get("ErrorRecipient"); }
        }

        /// <summary>
        /// Reusable method that will send an email to the list of email(s) in the parameter.
        /// </summary>
        /// <param name="emailAddressFrom">From Address</param>
        /// <param name="emailDisplayName">From Display Name</param>
        /// <param name="bccEmailAddressesSeparatedByComma">Recipient(s)</param>
        /// <param name="bodyHtmlOfEmail">Html Message Body</param>
        /// <param name="subject">Message Subject</param>
        /// <returns></returns>
        public static bool SendEmail(string emailAddressFrom = "", string emailDisplayName = "", string bccEmailAddressesSeparatedByComma = "", string bodyHtmlOfEmail = "", string subject = "")
        {
            try
            {
                var m = new MailMessage { From = new MailAddress(emailAddressFrom, emailDisplayName) };
                m.Bcc.Add(bccEmailAddressesSeparatedByComma);
                m.Body = bodyHtmlOfEmail;
                m.Subject = subject;
                m.IsBodyHtml = true;
                var smtpClient = new SmtpClient();
                smtpClient.Send(m);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        
        /// <summary>
        /// Reusable method that will send an email to one or more people.
        /// Use comma-delimited addresses for multiple "to" or "bcc" recipients.
        /// </summary>
        /// <param name="emailAddressFrom">From Address</param>
        /// <param name="emailDisplayName">From Display Name</param>
        /// <param name="toEmailAddress">To Address</param>
        /// <param name="ccEmailAddress">CC Address</param>
        /// <param name="bccEmailAddress">BCC Address</param>
        /// <param name="bodyOfEmail">Body of Message</param>
        /// <param name="isHtml">Message Body is Html</param>
        /// <param name="subject">Subject Line</param>
        /// <returns></returns>
        public static bool SendEmail(string emailAddressFrom = "", string emailDisplayName = "", string toEmailAddress = "", string ccEmailAddress = "", string bccEmailAddress = "", string bodyOfEmail = "", bool isHtml = false, string subject = "")
        {
            try
            {
                var m = new MailMessage
                {
                    From = new MailAddress(emailAddressFrom, emailDisplayName)
                };
                m.To.Add(toEmailAddress);
                m.CC.Add(ccEmailAddress);
                m.Bcc.Add(bccEmailAddress);
                m.Body = bodyOfEmail;
                m.Subject = subject;
                m.IsBodyHtml = isHtml;
                var smtpClient = new SmtpClient();
                smtpClient.Send(m);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Use for sending emails to a debug user, rather than an end user, when the "IsDebug" flag is set
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private static string GetEmailAddress(string email)
        {
            var emailAdd = email;
            if (System.Configuration.ConfigurationSettings.AppSettings.AllKeys.Contains("DebugEmail"))
            {
                if (System.Configuration.ConfigurationSettings.AppSettings.Get("DebugEmail") != "")
                {
                    emailAdd = System.Configuration.ConfigurationSettings.AppSettings.Get("DebugEmail");
                }
            }
            return emailAdd;
        }

        #endregion Email Methods

        /*
        #region User Attributes

        /// <summary>
        /// Returns Email Address for the specified EMPLID.
        /// </summary>
        /// <returns></returns>
        public static string GetUsersEmail(string emplid)
        {
            using (var db = new ProjectEntities())
            {
                return db.Users.First(x => x.EMPLID == emplid).Email;
            }
        }

        /// <summary>
        /// Returns the number of User Ids assigned to an individual.
        /// </summary>
        /// <param name="emplid"></param>
        /// <returns></returns>
        public static int GetNumberOfUserIds(string emplid)
        {
            using (var db = new ProjectEntities())
            {
                return db.Users.Count(x => x.EMPLID == emplid);
            }
        }

        #endregion User Attributes
        */

        /*
        #region Academic Terms

        /// <summary>
        /// Returns the Current Term Code
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentTerm()
        {
            using (var db = new ProjectEntities())
            {
                return db.UTIL_GetCurrentTermCode().First();
            }
        }

        /// <summary>
        /// Returns the corresponding name of the numeric term.
        /// </summary>
        /// <param name="strYear"></param>
        /// <param name="sem"></param>
        /// <returns></returns>
        protected static string CreateTextTerm(int strYear, string sem)
        {
            switch (sem)
            {
                case "1":
                    return "Spring " + strYear;
                case "2":
                case "3": // added for FLPR usage
                    return "Summer " + strYear;
                case "4":
                    return "Fall " + strYear;
                case "5":
                    return "Winter " + strYear;
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Reconstitutes the year from the term code. 
        /// </summary>
        /// <param name="currTerm"></param>
        /// <returns></returns>
        protected static int CreateTermYearString(string currTerm)
        {
            return Convert.ToInt32(currTerm.Substring(0, 1) + "0" + currTerm.Substring(1, 2));
        }

        /// <summary>
        /// Creates a text/value pair of a term and its description.
        /// </summary>
        /// <param name="currTerm"></param>
        /// <returns></returns>
        public static TextValuePair ParseTerm(string currTerm)
        {
            var sem = currTerm.Substring(3, 1); // 1,2,4,5
            var strYear = CreateTermYearString(currTerm); // 2014, 2015, 2016, etc.
            var txtTerm = CreateTextTerm(strYear, sem); // "Fall 2014", "Spring 2015"
            return new TextValuePair()
            {
                DataValue = currTerm,
                DataText = txtTerm
            };
        }

        private static TextValuePair FormatTermCode(string currTerm, bool hasRoute)
        {
            var sem = currTerm.Substring(3, 1); // 1 or 4 (spring/fall)
            var strQueryString = CreateDataValue(currTerm, hasRoute);
            var strOptionText = CreateOptionText(currTerm); //CreateOptionText(strTermDescription, strYear);

            return new TextValuePair()
            {
                DataText = strOptionText,
                DataValue = strQueryString
            };
        }

        private static string CreateOptionText(string strTerm, string strDivision)
        {
            var sb = new StringBuilder();
            sb.Append(strTerm + strDivision.Substring(0, 1).ToLower());
            return sb.ToString();
        }

        private static string CreateOptionText(string strTermDescription)
        {
            var sb = new StringBuilder();
            sb.Append(@"<strTermDescription>");
            sb.Replace(@"<strTermDescription>", strTermDescription);
            return sb.ToString();
        }


        /// <summary>
        /// Create list of term codes.
        /// </summary>
        /// <param name="strTermCode"></param>
        /// <param name="hasRoute"></param>
        /// <returns></returns>
        private static string CreateDataValue(string strTermCode, bool hasRoute)
        {
            var sb = new StringBuilder();
            sb.Append(hasRoute ? @"/<strTermCode>" : @"?term=<strTermCode>");
            sb.Replace(@"<strTermCode>", strTermCode);
            return sb.ToString();
        }

        #endregion Academic Terms

        #region EDS-Related

        public static Dictionary<string, string> GetPersonAttributes(Person p)
        {
            var personAttributes = new Dictionary<string, string>();
            foreach (var a in p.Attributes)
            {
                foreach (var t in a.Values)
                {
                    switch (a.Name.ToLower())
                    {
                        case "emplid":
                        case "uid":
                        case "mail":
                        case "preferredsn":
                        case "preferredgivenname":
                        case "sn":
                        case "givenname":
                            personAttributes.Add(a.Name, t);
                            break;
                        case "employeephone":
                            long phone;
                            long.TryParse(t, out phone);

                            if (phone != 0)
                            {
                                var phoneNumber = String.Format("{0:###/###-####}", phone);
                                personAttributes.Add(a.Name, phoneNumber);
                            }

                            break;
                    }
                }
            }
            return personAttributes;
        }

        public static void DisplayPersonProperties(Dictionary<string, string> person)
        {
            Dictionary<string, string> dct = person.ToDictionary(rec => rec.Key, rec => rec.Value);
            Console.WriteLine("===================================");
            Console.WriteLine("NetId: " + dct["uid"]);
            Console.WriteLine("Name: " + dct["givenName"] + " " + dct["sn"]);
            Console.WriteLine("EmplId: " + dct["emplId"]);
            Console.WriteLine("Email: " + dct["mail"]);
            Console.WriteLine("Phone: " + dct["employeePhone"]);
            Console.WriteLine("===================================");
        }

        /// <summary>
        /// Uses EDS to lookup user based on entry in the impersonate text box.
        /// Regular expressions are applied to determine if the user input is legit.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Person AttemptToLookupUserToAdd(string input)
        {
            Person p = null;
            var rgxNetId = new Regex(@"[A-Za-z0-9\-]{2,16}");
            var rgxEmplId = new Regex(@"\d{8}");

            if (HelperMethods.IsNumeric(input))
            {
                if (rgxEmplId.IsMatch(input)) // 8-digit number
                {
                    p = new Person(input, PersonLookupType.EmplId);
                }
            }
            else // not strictly numeric
            {
                if (rgxNetId.IsMatch(input)) // 2 to 16 character alphanumeric value
                {
                    try
                    {
                        p = new Person(input, PersonLookupType.NetId);
                    }
                    catch
                    {
                        p = null;
                    }
                }
            }
            return p;
        }

        #endregion EDS-Related
         * */
    }
}
