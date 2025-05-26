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
            if (query.Contains("password")) // Check for specific keywords in the query and return appropriate responses
            {
                return "Enhancing Password Safety: Key Recommendations\r\nCreate Strong and Complex Passwords\r\nUse a combination of uppercase and lowercase letters, numbers, and special characters. Avoid common words, simple sequences, or easily guessable patterns to reduce vulnerability to guessing and brute-force attacks.\r\n\r\nMake Passwords Long\r\nAim for passwords that are at least 12 characters in length. Longer passwords exponentially increase the difficulty for attackers attempting to crack them.\r\n\r\nUse Unique Passwords for Every Account\r\nNever reuse passwords across multiple sites. Unique passwords ensure that if one account is compromised, others remain secure.\r\n\r\nLeverage Password Managers\r\nUtilize reputable password managers to generate, store, and autofill complex passwords securely. This eliminates the need to remember multiple strong passwords and reduces the temptation to reuse them.\r\n\r\nEnable Multi-Factor Authentication (MFA)\r\nAdd an extra layer of protection by requiring a second form of verification (such as a text message code, authentication app, or biometric factor) in addition to your password.\r\n\r\nRegularly Update Passwords\r\nChange your passwords periodically, especially if you suspect any account may have been compromised or after a data breach notification.\r\n\r\nStay Vigilant Against Phishing Attempts\r\nAlways verify the legitimacy of emails, messages, and websites before entering your password. Phishing attacks often mimic trusted sources to steal credentials.\r\n\r\nKeep Your Software and Devices Updated\r\nRegularly update your operating system, browsers, and security software to protect against malware and keyloggers that can capture your passwords.\r\n\r\n";
            }
            else if (query.Contains("cybersecurity"))
            {
                return "What is Cybersecurity?\r\nCybersecurity refers to the practice of protecting computers, servers, networks, devices, and data from unauthorized access, attacks, damage, or theft. It encompasses a wide range of technologies, processes, and measures designed to safeguard digital information and ensure the confidentiality, integrity, and availability of data.\r\n\r\nAs our reliance on digital systems grows—whether for personal use, business operations, or critical infrastructure—cybersecurity has become essential to defend against cyber threats such as hacking, malware, ransomware, phishing, and other forms of cybercrime.";
            }
            else if (query.Contains("phishing"))
            {
                return "Be Wary of Phishing Attempts\r\nPhishing is a common cyberattack technique where attackers impersonate legitimate organizations or contacts to trick you into revealing sensitive information, such as your passwords. These attacks often come in the form of emails, text messages, phone calls, or fake websites that look authentic.\r\n\r\nHow Phishing Works:\r\n\r\nYou might receive an email that appears to be from your bank, a popular online service, or even a colleague.\r\nThe message often creates a sense of urgency, asking you to “verify your account,” “reset your password,” or “confirm personal details.”\r\nThe email contains a link to a fraudulent website designed to look like the real one, where you are prompted to enter your password or other private information.\r\nOnce entered, attackers capture your credentials and can use them to access your accounts.\r\nHow to Protect Yourself from Phishing:\r\n\r\nVerify the Sender: Check the sender’s email address carefully. Phishing emails often use addresses that look similar but have subtle differences.\r\nLook for Red Flags: Poor grammar, spelling mistakes, generic greetings (like “Dear Customer”), and unexpected attachments or links are common signs of phishing.\r\nDon’t Click Suspicious Links: Instead of clicking links in emails, manually type the website’s URL into your browser or use a trusted bookmark.\r\nCheck Website Security: Ensure the website uses HTTPS (look for the padlock icon in the address bar) before entering any credentials.\r\nUse Anti-Phishing Tools: Many browsers and email services offer built-in phishing detection and warnings—keep these enabled.\r\nBe Skeptical of Urgency: Phishing messages often pressure you to act quickly. Take your time to verify the request through official channels.\r\nEducate Yourself and Others: Awareness is key. Regularly update yourself on common phishing tactics and share this knowledge with friends, family, or colleagues.\r\nBy staying vigilant and cautious, you can greatly reduce the risk of falling victim to phishing attacks and keep your passwords and personal information safe.";
            }
            else if (query.Contains("safe browsing"))
            {
                return "Tips for Safe Browsing\r\nUse Secure Websites (HTTPS):\r\nAlways check that the website URL begins with “https://” and displays a padlock icon. This indicates the site uses encryption to protect data transmitted between your browser and the website.\r\n\r\nKeep Your Browser Updated:\r\nRegularly update your web browser to the latest version. Updates often include security patches that protect against newly discovered vulnerabilities.\r\n\r\nEnable Browser Security Features:\r\nUse built-in security features like pop-up blockers, phishing filters, and “Do Not Track” settings to reduce exposure to malicious content.\r\n\r\nAvoid Clicking on Suspicious Links:\r\nBe cautious about clicking links in emails, social media, or unfamiliar websites. Hover over links to preview the URL before clicking.\r\n\r\nUse Strong, Unique Passwords:\r\nWhen creating accounts, use strong passwords and avoid reusing them across sites. Consider using a password manager to keep track of them securely.\r\n\r\nBe Careful with Public Wi-Fi:\r\nAvoid accessing sensitive accounts or conducting financial transactions over unsecured public Wi-Fi networks. If necessary, use a trusted Virtual Private Network (VPN) to encrypt your connection.\r\n\r\nLimit Personal Information Sharing:\r\nAvoid sharing sensitive personal information on websites unless absolutely necessary and ensure the site is trustworthy.\r\n\r\nBeware of Downloads and Extensions:\r\nOnly download files, software, or browser extensions from reputable sources. Malicious downloads can infect your device with malware.\r\n\r\nClear Browsing Data Regularly:\r\nPeriodically clear your cache, cookies, and browsing history to protect your privacy and reduce tracking.\r\n\r\nUse Antivirus and Anti-Malware Software:\r\nKeep security software active and updated to detect and block threats encountered while browsing.";
            }
            else if (query.Contains("how are you"))
            {
                return "I'm just a program, but I'm here to help you with cybersecurity!";
            }
            else if (query.Contains("what is your purpose"))
            {
                return "My purpose is to assist you with questions about cybersecurity.";
            }
            else if (query.Contains("what can i ask you about"))
            {
                return "You can ask me about password safety, phishing, and safe browsing.";
            }
            else
            {
                return "I didn't quite understand that. Could you rephrase?";
            }
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
