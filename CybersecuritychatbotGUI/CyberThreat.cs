using System;

namespace threats
{
    public class CyberThreat
    {
        public CyberThreat() {}

        public string getPhishing()
        {
            return "Phishing is a type of cyber attack where attackers send fraudulent messages(usually emails) pretending to be from a reputable source.\n"+
			"The aim is to trick the recipient into revealing sensitive information such as login credentials, credit card numbers, or personal data.";
        }

        public string getMalware()
        {
            return "Malware(malicious software) is any software intentionally designed to cause damage to a computer, server, client, or network. \n"+
			"Examples include:\n 1.Viruses \n 2.Worms \n 3.Trojans \n 4.Ransomware \n 5.Spyware.";
        }

        public string getRansomware()
        {
            return "Ransomware is a form of malware that encrypts a victim's files. \n"+
			"The attacker then demands a ransom from the victim to restore access to the data upon payment.";
        }

        public string getManInTheMiddle()
        {
            return "Man-in-the-Middle(MitM) attack occurs when a third party intercepts communication between two parties, often to steal data or impersonate one of the parties involved.";
        }

        public string getSQLInjection()
        {
            return "SQL Injection is a web security vulnerability that allows an attacker to interfere with the queries an application makes to its database.\n"+
			"It can allow access to sensitive data, modification of data, and administrative operations.";
        }

        public string getDenialOfService()
        {
            return "Denial-of-Service(DoS) attack aims to make a machine or network resource unavailable to its intended users by overwhelming it with traffic or sending information that triggers a crash.";
        }

        public string getZeroDayExploit()
        {
            return "Zero-Day Exploit is an attack that occurs on the same day a vulnerability is discovered in software, before a fix becomes available. Attackers exploit the flaw before developers patch it.";
        }

        public string getSpyware()
        {
            return "Spyware is malicious software designed to enter your device, gather data about you, and forward it to a third-party without your consent.";
        }

        public string getTrojanHorse()
        {
            return "Trojan Horse is a type of malware disguised as legitimate software. Once installed, it can give attackers unauthorized access to the system.";
        }

        public string getRootkit()
        {
            return "Rootkit is a collection of software tools that enable an unauthorized user to gain control of a computer system without being detected.";
        }

        public string getKeylogger()
        {
            return "Keyloggers are malicious programs or hardware devices that record every keystroke made on a computer, often used to steal passwords or sensitive data.";
        }

        public string getBotnet()
        {
            return "Botnet is a network of infected computers (bots) controlled remotely by an attacker, often used to launch large-scale attacks like DDoS.";
        }

        public string getSocialEngineering()
        {
            return "Social Engineering is a tactic that relies on human interaction to trick users into breaking security procedures and giving away sensitive information.";
        }

        public string getCredentialStuffing()
        {
            return "Credential Stuffing is a cyber attack where stolen account credentials, typically consisting of lists of usernames and/or email addresses and the corresponding passwords, are used to gain unauthorized access to user accounts.";
        }
    }
}