using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_jttt
{
    // W klasie tworzone będą obiekty DataInput dla odpowiednich warunków
    class DataInputCreator
    {
        DataInput sendEMail;
        DataInput showImage;
        DataInput findKeyInImageTitle;

        public DataInputCreator()
        {
            // Na start w konstruktorze tworzymy wszystkie DataInput'y dla wszystkich warunków/akcji
            sendEMail = new DataInput();
            sendEMail.SetTitle(new string[] {"Wyslij email z zalaczonym obrazkiem", "na podany adres email"});
            sendEMail.AddTextInput("Email");

            showImage = new DataInput();
            showImage.SetTitle(new string[] { "Pokazuje obrazek w nowym oknie" });

            findKeyInImageTitle = new DataInput();
            findKeyInImageTitle.SetTitle(new string[] { "Jesli na stronie znajduje sie obrazek", "zawierajacy klucz w opisie" });
            findKeyInImageTitle.AddTextInput("URL");
            findKeyInImageTitle.AddTextInput("Klucz");
        }

        public DataInput GetConditionInput(int num)
        {
            return findKeyInImageTitle;
        }

        public DataInput GetActionInput(int num)
        {
            if (num == 0)
                return sendEMail;
            else
                return showImage;
        }
    }
}
