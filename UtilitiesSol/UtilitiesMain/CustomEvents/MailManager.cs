using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UtilitiesMain.CustomEvents
{



    public class MailManager
    {



        // Třídu MailMsgEventArgs definujeme jako vnitřní třídu uvnitř třídy MailManager.
        public class MailMsgEventArgs : EventArgs
        {
            // 1. Typ, který definuje informaci předávanou předplatitelům události.

            public readonly string from;
            public readonly string to;
            public readonly string subject;
            public readonly string body;

            public MailMsgEventArgs(string from, string to, string subject, string body)
            {
                this.from = from;
                this.to = to;
                this.subject = subject;
                this.body = body;
            }
        }



        // 2. Delegát, který definuje prototyp tzv. callback metody, kterou musí definovat každý, kdo se registroval, aby byl upozorněn při výskytu události.
        public delegate void MailMsgEventHandler(object sender, MailMsgEventArgs args);

        // 3. Samotná událost MailMsg.
        public event MailMsgEventHandler MailMsg;



        // 4. Metoda (virtuální a protected), která odpovídá za upozornění registrovaných objektů, že došlo k události.
        protected virtual void OnMailMsg(MailMsgEventArgs e)
        {
            // Jsou nějaké objekty registrované k odběru události?
            if (MailMsg != null)
            {
                // Ano. Upozorni tedy všechny objekty registrované ve spojovém seznamu, který spravuje delegát.
                MailMsg(this, e);
            }
        }



        // 5. Metoda, která převádí vstup na požadovanou událost. Tato metoda se volá v okamžiku, kdy přijde emailová zpráva.
        public void SimulateArrivingMsg(string from, string to, string subject, string body)
        {
            // Vytvoříme objekt, do kterého uložíme informaci, která se má předat příjemcům upozornění.
            MailMsgEventArgs e = new MailMsgEventArgs(from, to, subject, body);

            // Zavoláme virtuální metodu, která upozorní náš objekt, že došlo k události. Pokud žádný potomek této třídy tuto metodu nepřekryje, náš objekt odešle upozornění všem registrovaným observerům.
            OnMailMsg(e);
        }




    }



}
