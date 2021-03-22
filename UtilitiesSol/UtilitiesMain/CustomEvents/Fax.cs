using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UtilitiesMain.CustomEvents
{



    public class Fax
    {



        private string name;
        private MailManager.MailMsgEventHandler faxMsgDelegate;



        //public Fax(MailManager mm)
        // Předáme objekt MailManager jako parametr konstruktoru.
        public Fax(MailManager mm, string name)
        {
            // Vytvoříme instanci delegáta MailMsgEventHandler, která bude odkazovat na callback metodu FaxMsg. Tuto callback metodu zaregistrujeme u MailManagera pro odběr události MailMsg.
            //mm.MailMsg += new MailManager.MailMsgEventHandler(FaxMsg);
            this.faxMsgDelegate = new MailManager.MailMsgEventHandler(FaxMsg);
            mm.MailMsg += this.faxMsgDelegate;
            this.name = name;
        }



        // Tuto metodu zavolá MailManager, aby upozornil objekt Fax na nový příchozí email.
        private void FaxMsg(object sender, MailManager.MailMsgEventArgs e)
        {
            // Parametr sender odkazuje na MailManagera a lze použít na zpětnou komunikaci s ním.
            // Druhý parametr, tj. e obsahuje dodatečné informace spojené s událostí, které chce MailManager poskytnout svým předplatitelům.
            // Normálně by se tady odeslala faxová zpráva. Testovací implementace vypíše info o emailu pouze na konzoli.
            //Console.WriteLine("Faxuji emailovou zprávu:");
            Console.WriteLine($"Faxuji emailovou zprávu přes fax {this.name}:");
            Console.WriteLine($"    To:      {e.to}");
            Console.WriteLine($"    From:    {e.from}");
            Console.WriteLine($"    Subject: {e.subject}");
            Console.WriteLine($"    Body:    {e.body}");
        }



        public void Unregister(MailManager mm)
        {
            // Vytvoříme instanci delegáta MailMsgEventHandler, která odkazuje na callback metodu FaxMsg.
            //MailManager.MailMsgEventHandler callback = new MailManager.MailMsgEventHandler(FaxMsg);
            // Odregistrujeme zájem o událost MailMsg.
            //mm.MailMsg -= callback;
            mm.MailMsg -= this.faxMsgDelegate;
        }



    }



}
