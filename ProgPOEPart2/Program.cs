using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgPOEPart2
{
    class Program
    {
        private static Random rand = new Random();
        private static string lastTip = string.Empty;
        static void Main(string[] args)
        {
            string audioFilePath = "C:\\Users\\siyan\\source\\repos\\ProgPOEPart2\\ProgPOEPart2\\bin\\Debug\\Project name (en) v2.wav";

            using (SoundPlayer player = new SoundPlayer(audioFilePath))
            {
                try
                {
                    player.Load();
                    player.PlaySync();
                    Console.WriteLine("          .--.      " +
                        "\r\n         |o_o |     " +
                        "\r\n         |:_/ |     " +
                        "\r\n        //   \\ \\    " +
                        "\r\n       (|     | )   " +
                        "\r\n      /'\\_   _/`\\" +
                        "\r\n      \\___)=(___/" +
                        "\nYOUR CYBERSECURITY CHATBOT");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                string userName = Name();
                TypingEffect($"Welcome, {userName}! How can I assist you today?");

                while (true)
                {
                    Console.WriteLine($"{userName}, you can ask me anything (type 'exit' to quit): ");
                    string userInput = Console.ReadLine();

                    if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        TypingEffect("Thank you for chatting! Goodbye!");
                        break;
                    }

                    string response = RespondToQuery(userInput);
                    TypingEffect(response);
                }
            }
        }

        // Method to respond to user queries
        static string RespondToQuery(string query)
        {
            query = query.ToLower();
            List<string> responses = new List<string>(); // List to collect responses

            // Check for keywords and add corresponding responses
            if (query.Contains("password"))
            {
                responses.Add(GetRandomPasswordTip());
            }
            if (query.Contains("scam"))
            {
                responses.Add(GetRandomScamTip());
            }
            if (query.Contains("privacy"))
            {
                responses.Add(GetRandomPrivacyTip());
            }
            if (query.Contains("phishing"))
            {
                responses.Add(GetRandomPhishingTip());
            }
            if (query.Contains("malware"))
            {
                responses.Add(GetRandomMalwareTip());
            }
            if (query.Contains("two-factor authentication") || query.Contains("2fa"))
            {
                responses.Add(GetRandom2FATip());
            }
            if (query.Contains("safe browsing"))
            {
                responses.Add(GetRandomSafeBrowsingTip());
            }
            if (query.Contains("social engineering"))
            {
                responses.Add(GetRandomSocialEngineeringTip());
            }
            if (query.Contains("data breach"))
            {
                responses.Add(GetRandomDataBreachTip());
            }
            if (query.Contains("cybersecurity best practices"))
            {
                responses.Add(GetRandomCybersecurityBestPracticesTip());
            }
            if (query.Contains("how are you"))
            {
                responses.Add("I'm just a program, but I'm here to help you with cybersecurity!");
            }
            if (query.Contains("what is your purpose"))
            {
                responses.Add("My purpose is to assist you with questions about cybersecurity.");
            }
            if (query.Contains("what can i ask you about"))
            {
                responses.Add("You can ask me about password safety, phishing, and safe browsing.");
            }
            if (query.Contains("thank you") || query.Contains("thanks"))
            {
                responses.Add("You're welcome! If you have more questions, feel free to ask.");
            }

            // If no responses were added, return a default message
            if (responses.Count == 0)
            {
                return "I didn't quite understand that. Could you rephrase?";
            }

            // Combine all responses into a single string
            return string.Join("\n", responses);
        }

        // Method to get a random tip based users input
        static string GetRandomPhishingTip()
        {
            List<string> phishing = new List<string>
            {
        "Be cautious of emails asking for personal information. Scammers often disguise themselves as trusted organizations.",
        "Always verify the sender's email address. Phishing emails often use addresses that look similar but have subtle differences.",
        "Don't click on suspicious links. Instead, manually type the website's URL into your browser.",
        "Look for spelling and grammatical errors in emails. Legitimate organizations usually proofread their communications.",
        "Be wary of urgent requests for information. Scammers often create a sense of urgency to trick you into acting quickly.",
        "Check the URL of the website before entering any personal information. Ensure it matches the official site.",
        "Use security software that can help detect phishing attempts and alert you to potential threats.",
        "Educate yourself about common phishing tactics to recognize them when they occur."
            };
            return GetRandomTip(phishing);
        }

        static string GetRandomPasswordTip()
        {
            List<string> password = new List<string>
            {
        "Use a mix of letters, numbers, and special characters in your passwords.",
        "Avoid using the same password across multiple sites.",
        "Consider using a password manager to keep track of your passwords securely.",
        "Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords.",
        "Change your passwords regularly, especially if you suspect any account may have been compromised.",
        "Enable multi-factor authentication (MFA) wherever possible for an extra layer of security.",
        "Avoid using easily guessable passwords, such as '123456' or 'password'.",
        "Create passphrases by combining random words for stronger security."
            };
            return GetRandomTip(password);
        }

        static string GetRandomScamTip()
        {
            List<string> scam = new List<string>
            {
        "Never share your personal information with unknown sources.",
        "Be wary of unsolicited emails or messages that ask for sensitive information.",
        "Always verify the legitimacy of a request before responding.",
        "Be cautious of scams. Always verify the source before providing any personal information.",
        "If an offer seems too good to be true, it probably is. Trust your instincts.",
        "Research the company or individual making the request to ensure they are legitimate.",
        "Do not provide personal information over the phone unless you initiated the call.",
        "Report any suspicious emails or messages to your email provider or local authorities."
            };
            return GetRandomTip(scam);
        }

        static string GetRandomPrivacyTip()
        {
            List<string> privacy = new List<string>
            {
        "Regularly update your privacy settings on social media platforms.",
        "Be mindful of the information you share online, even in private messages.",
        "Use two-factor authentication to enhance your account security.",
        "It's crucial to protect your privacy online. Regularly review your privacy settings on social media.",
        "Limit the amount of personal information you share publicly on social media.",
        "Be cautious about friend requests from unknown individuals.",
        "Review the permissions of apps connected to your social media accounts and remove any that are unnecessary.",
        "Consider using a VPN when accessing public Wi-Fi to protect your data."
            };
            return GetRandomTip(privacy);
        }

        static string GetRandomMalwareTip()
        {
            List<string> malwareTips = new List<string>
            {
        "Keep your antivirus software updated to protect against malware.",
        "Be cautious when downloading files or clicking on links from unknown sources.",
        "Regularly scan your computer for malware to ensure it's clean.",
        "Avoid using pirated software, as it often contains malware.",
        "Use a firewall to help protect your network from unauthorized access.",
        "Be wary of email attachments, especially from unknown senders.",
        "Educate yourself about the latest malware threats and how to avoid them.",
        "Consider using a dedicated malware removal tool for added protection."
            };
            return GetRandomTip(malwareTips);
        }

        static string GetRandom2FATip()
        {
            List<string> twoFATips = new List<string>
            {
        "Enable two-factor authentication (2FA) on your accounts for added security.",
        "Use an authenticator app for generating 2FA codes instead of SMS for better security.",
        "Always back up your 2FA recovery codes in a secure location.",
        "Be aware that 2FA is not foolproof; always combine it with strong passwords.",
        "Consider using biometric authentication (like fingerprint or facial recognition) as a second factor.",
        "Regularly review your 2FA settings and update them as necessary.",
        "Be cautious of phishing attempts that target your 2FA codes.",
        "Use 2FA on all accounts that support it, especially email and financial accounts."
            };
            return GetRandomTip(twoFATips);
        }

        static string GetRandomSafeBrowsingTip()
        {
            List<string> safeBrowsingTips = new List<string>
            {
        "Always check the URL for 'https://' before entering sensitive information.",
        "Use a reputable browser that offers security features and updates regularly.",
        "Avoid clicking on pop-up ads or suspicious links while browsing.",
        "Consider using browser extensions that enhance security and privacy.",
        "Clear your browser cache and cookies regularly to protect your privacy.",
        "Use a VPN when accessing public Wi-Fi to encrypt your internet connection.",
        "Be cautious about sharing personal information on social media.",
        "Disable location services in your browser to prevent tracking."
            };
            return GetRandomTip(safeBrowsingTips);
        }

        static string GetRandomSocialEngineeringTip()
        {
            List<string> socialEngineeringTips = new List<string>
            {
        "Be cautious of unsolicited requests for personal information.",
        "Verify the identity of anyone asking for sensitive information, especially over the phone.",
        "Educate yourself about common social engineering tactics to recognize them.",
        "Always think twice before sharing information, even with trusted contacts.",
        "Be aware of the tactics used in pretexting, baiting, and tailgating.",
        "Never disclose sensitive information in response to unexpected requests.",
        "Use secure methods to share sensitive information, such as encrypted messaging.",
        "Stay informed about the latest social engineering scams and tactics."
            };
            return GetRandomTip(socialEngineeringTips);
        }

        static string GetRandomDataBreachTip()
        {
            List<string> dataBreachTips = new List<string>
            {
        "Regularly monitor your accounts for unauthorized activity.",
        "Use unique passwords for each account to minimize risk in case of a breach.",
        "Consider using a service that alerts you to data breaches involving your information.",
        "If you suspect a breach, change your passwords immediately and enable 2FA.",
        "Review your credit report regularly for any unusual activity.",
        "Consider placing a fraud alert on your credit report if you suspect a breach.",
        "Be cautious of phishing emails that may follow a data breach notification.",
        "Educate yourself on how to respond to a data breach effectively."
            };
            return GetRandomTip(dataBreachTips);
        }

        static string GetRandomCybersecurityBestPracticesTip()
        {
            List<string> bestPracticesTips = new List<string>
            {
        "Regularly update your software and operating systems to patch vulnerabilities.",
        "Educate yourself and others about cybersecurity risks and safe practices.",
        "Back up your data regularly to prevent loss in case of an attack.",
        "Use strong, unique passwords and consider a password manager.",
        "Implement a security policy for your home network and devices.",
        "Be cautious about the permissions you grant to apps and services.",
        "Regularly review and update your security settings on all accounts.",
        "Stay informed about the latest cybersecurity trends and threats."
            };
            return GetRandomTip(bestPracticesTips);
        }

        // Helper method to get a random tip from a list
        static string GetRandomTip(List<string> tips)
        {
            string newTip;
            do
            {
                newTip = tips[rand.Next(tips.Count)];
            } while (newTip == lastTip); // Ensure it's not the same as the last tip
            lastTip = newTip;
            return newTip;
        }

        static string Name()
        {
            string name;
            do
            {
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Invalid input. Please enter a valid name.");
                }
            } while (string.IsNullOrEmpty(name));

            return name;
        }

        // Method to create a typing effect for text output
        static void TypingEffect(string text, ConsoleColor color = ConsoleColor.DarkRed, int delay = 10)
        {
            int windowWidth = Console.WindowWidth;
            int textLength = text.Length;
            int leftPadding = (windowWidth - textLength) / 2;
            if (leftPadding < 0) leftPadding = 0;
            Console.ForegroundColor = color;
            Console.SetCursorPosition(leftPadding, Console.CursorTop);
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
