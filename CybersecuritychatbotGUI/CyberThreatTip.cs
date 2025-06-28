using System;

namespace tips
{
    public class CyberThreatTip
    {
        public CyberThreatTip() {}

        public string getPhishingTip()
        {
            return "Tips to stay safe from Phishing:\n"+
			"1. Do not click on suspicious links or attachments.\n"+
			"2. Verify the sender’s email address.\n"+
			"3. Use spam filters to block malicious emails.\n"+
			"4. Enable two-factor authentication on all accounts.";
        }

        public string getMalwareTip()
        {
            return "Tips to stay safe from Malware:\n"+
			"1. Install and update reputable antivirus software.\n"+
			"2. Avoid downloading files from untrusted websites.\n"+
			"3. Keep your operating system and apps updated.\n"+
			"4. Be cautious of pop-ups and unknown websites.";
        }

        public string getRansomwareTip()
        {
            return "Tips to stay safe from Ransomware:\n"+
			"1. Regularly back up your important files.\n"+
			"2. Avoid opening suspicious email attachments.\n"+
			"3. Keep antivirus and security software updated.\n"+
			"4. Use endpoint protection tools with ransomware detection.";
        }

        public string getManInTheMiddleTip()
        {
            return "Tips to stay safe from Man-in-the-Middle attacks:\n"+
			"1. Use websites with HTTPS encryption.\n"+
			"2. Avoid public Wi-Fi for sensitive activities.\n"+
			"3. Use a VPN on public or unsecured networks.\n"+
			"4. Keep your firmware and software updated.";
        }

        public string getSQLInjectionTip()
        {
            return "Tips to stay safe from SQL Injection:\n"+
			"1. Use parameterized queries and prepared statements.\n"+
			"2. Validate and sanitize all user inputs.\n"+
			"3. Avoid building SQL queries from raw user input.\n"+
			"4. Use secure ORM frameworks for database access.";
        }

        public string getDenialOfServiceTip()
        {
            return "Tips to stay safe from Denial-of-Service attacks:\n"+
			"1. Use firewalls and intrusion detection systems.\n"+
			"2. Apply rate limiting to APIs and services.\n"+
			"3. Use a content delivery network (CDN).\n"+
			"4. Create and test an incident response plan.";
        }

        public string getZeroDayExploitTip()
        {
            return "Tips to stay safe from Zero-Day Exploits:\n"+
			"1. Enable automatic updates for software and systems.\n"+
			"2. Use advanced threat detection solutions.\n"+
			"3. Segment your network to limit access.\n"+
			"4. Monitor systems for unusual or suspicious activity.";
        }

        public string getSpywareTip()
        {
            return "Tips to stay safe from Spyware:\n"+
			"1. Avoid downloading software from unknown sources.\n"+
			"2. Use reliable anti-spyware and antivirus tools.\n"+
			"3. Do not click on fake ads or update prompts.\n"+
			"4. Regularly scan your system for threats.";
        }

        public string getTrojanHorseTip()
        {
            return "Tips to stay safe from Trojan Horses:\n"+
			"1. Only download software from trusted vendors.\n"+
			"2. Keep your antivirus software up to date.\n"+
			"3. Be careful with links and attachments in emails.\n"+
			"4. Watch for unusual system behavior or apps.";
        }

        public string getRootkitTip()
        {
            return "Tips to stay safe from Rootkits:\n"+
			"1. Use rootkit detection and removal tools.\n"+
			"2. Avoid pirated or cracked software.\n"+
			"3. Monitor system integrity and logs regularly.\n"+
			"4. Reinstall the operating system if infection is suspected.";
        }

        public string getKeyloggerTip()
        {
            return "Tips to stay safe from Keyloggers:\n"+
			"1. Use a virtual keyboard for sensitive logins.\n"+
			"2. Keep antivirus software updated at all times.\n"+
			"3. Monitor for unknown or suspicious apps.\n"+
			"4. Enable two-factor authentication for important accounts.";
        }

        public string getBotnetTip()
        {
            return "Tips to stay safe from Botnets:\n"+
			"1. Keep operating systems and applications updated.\n"+
			"2. Use strong and unique passwords.\n"+
			"3. Avoid clicking on suspicious links or pop-ups.\n"+
			"4. Use firewalls and antivirus programs for protection.";
        }

        public string getSocialEngineeringTip()
        {
            return "Tips to stay safe from Social Engineering:\n"+
			"1. Verify a person's identity before sharing information.\n"+
			"2. Train staff to recognize common scam techniques.\n"+
			"3. Never share passwords or security codes.\n"+
			"4. Be cautious of urgent or emotional requests.";
        }

        public string getCredentialStuffingTip()
        {
            return "Tips to stay safe from Credential Stuffing:\n"+
			"1. Use different passwords for every online account.\n"+
			"2. Enable multi-factor authentication (MFA).\n"+
			"3. Monitor for unusual or suspicious login activity.\n"+
			"4. Use a password manager to store secure passwords.";
        }
    }
}