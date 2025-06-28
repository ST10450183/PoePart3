using threats;  // from CyberThreat.cs
using tips;     // from CyberThreatTip.cs
using System;

namespace CybersecuritychatbotGUI
{
    public class DisplayMessages
    {
        CyberThreat threat = new CyberThreat();
        CyberThreatTip tip = new CyberThreatTip();

        public string GetThreatDefinition(string input)
        {
            string key = input.ToLower();

            switch (key)
            {
                case "phishing": return threat.getPhishing();
                case "malware": return threat.getMalware();
                case "ransomware": return threat.getRansomware();
                case "man in the middle": return threat.getManInTheMiddle();
                case "sql injection": return threat.getSQLInjection();
                case "denial of service": return threat.getDenialOfService();
                case "zero day exploit": return threat.getZeroDayExploit();
                case "spyware": return threat.getSpyware();
                case "trojan horse": return threat.getTrojanHorse();
                case "rootkit": return threat.getRootkit();
                case "keylogger": return threat.getKeylogger();
                case "botnet": return threat.getBotnet();
                case "social engineering": return threat.getSocialEngineering();
                case "credential stuffing": return threat.getCredentialStuffing();
                default: return $"⚠ Sorry, no definition found for '{input}'.";
            }
        }

        public string GetThreatTips(string input)
        {
            string key = input.ToLower();

            switch (key)
            {
                case "phishing": return tip.getPhishingTip();
                case "malware": return tip.getMalwareTip();
                case "ransomware": return tip.getRansomwareTip();
                case "man in the middle": return tip.getManInTheMiddleTip();
                case "sql injection": return tip.getSQLInjectionTip();
                case "denial of service": return tip.getDenialOfServiceTip();
                case "zero day exploit": return tip.getZeroDayExploitTip();
                case "spyware": return tip.getSpywareTip();
                case "trojan horse": return tip.getTrojanHorseTip();
                case "rootkit": return tip.getRootkitTip();
                case "keylogger": return tip.getKeyloggerTip();
                case "botnet": return tip.getBotnetTip();
                case "social engineering": return tip.getSocialEngineeringTip();
                case "credential stuffing": return tip.getCredentialStuffingTip();
                default: return $"⚠ Sorry, no tips found for '{input}'.";
            }
        }
    }
}