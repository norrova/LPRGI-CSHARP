using System;
using System.Collections.Generic;
using System.Linq;
using Project.Human;
using Project.Web;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice 1");
            String m_text = "Lorem ipsum";
            Console.WriteLine(m_text.GetParagraph());
            Console.WriteLine(m_text.GetTitle(1));

            var data = new[]
            {
              new
              {
                  Id = "346309A5-9EE7-44E2-186D-9B8E9A8D67DA", Nom = "Jarvis", Prenom = "Elliott",
                  Email = "ligula.tortor.dictum@auguemalesuadamalesuada.ca", NombreCommande = 30,
                  PointsFidelite = 653, OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "D535EE24-BF6D-3233-3398-E8415E8B89BE", Nom = "Roman", Prenom = "Edward",
                  Email = "mollis.non@Aliquam.ca", NombreCommande = 19, PointsFidelite = 144, OptinCommercial = false,
                  Genre = "Homme"
              },
              new
              {
                  Id = "3FFEBA33-FA84-9729-B691-7827EF0DD7DF", Nom = "Bishop", Prenom = "Justine",
                  Email = "sollicitudin@ligulaelitpretium.co.uk", NombreCommande = 12, PointsFidelite = 542,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "90B6DB5F-F6F6-372B-DAD8-E5747159573E", Nom = "Wagner", Prenom = "Jorden",
                  Email = "eget.metus.In@Donecluctus.co.uk", NombreCommande = 38, PointsFidelite = 313,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "2551081B-A89A-B6A0-78A8-86055559EA75", Nom = "Casey", Prenom = "Kylie",
                  Email = "ut.pellentesque@orci.net", NombreCommande = 33, PointsFidelite = 837,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "8730D861-D91D-C24A-BF5B-12E277491294", Nom = "Nicholson", Prenom = "Ignatius",
                  Email = "enim@ataugueid.edu", NombreCommande = 40, PointsFidelite = 136, OptinCommercial = false,
                  Genre = "Femme"
              },
              new
              {
                  Id = "6A4125AE-ACE8-456F-F4A1-C9462E50435A", Nom = "Gardner", Prenom = "Wyatt",
                  Email = "at.egestas.a@adipiscingelitAliquam.com", NombreCommande = 6, PointsFidelite = 374,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "A0481257-4129-2579-73A6-95326EDBFDA5", Nom = "Lloyd", Prenom = "Patricia",
                  Email = "magna.Praesent.interdum@nonummy.net", NombreCommande = 16, PointsFidelite = 524,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "0C8C29D6-51F9-4EE6-EAEA-A9CCB3553DBD", Nom = "Wilkinson", Prenom = "Jerome",
                  Email = "lectus.rutrum.urna@nec.org", NombreCommande = 18, PointsFidelite = 732,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "E61797AB-292B-D0F3-87F7-901D98C87C2D", Nom = "Horn", Prenom = "Bell",
                  Email = "massa.Vestibulum@non.ca", NombreCommande = 46, PointsFidelite = 995,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "E95DF374-22AE-1B71-F0DA-1817C6EC0882", Nom = "Santiago", Prenom = "Raya",
                  Email = "mus@perconubia.net", NombreCommande = 3, PointsFidelite = 789, OptinCommercial = true,
                  Genre = "Femme"
              },
              new
              {
                  Id = "4DD00D67-3740-88C4-B3D8-394FB8757287", Nom = "Gross", Prenom = "Arsenio",
                  Email = "Donec.nibh.Quisque@rhoncusid.com", NombreCommande = 26, PointsFidelite = 50,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "6CBBC71E-19D8-2099-6D0E-32A09793EFFB", Nom = "Hinton", Prenom = "Selma",
                  Email = "Mauris.magna.Duis@scelerisqueneque.net", NombreCommande = 50, PointsFidelite = 975,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "317523CC-530F-8C3E-07A1-CB463B4DADE1", Nom = "Hall", Prenom = "Amity",
                  Email = "Nunc.commodo.auctor@facilisis.com", NombreCommande = 23, PointsFidelite = 857,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "750A676C-9984-5661-63BE-A2D269F68ADB", Nom = "Owens", Prenom = "Aiko",
                  Email = "In.at.pede@at.edu", NombreCommande = 7, PointsFidelite = 385, OptinCommercial = true,
                  Genre = "Homme"
              },
              new
              {
                  Id = "DC61D955-04A4-2761-2FE1-2E983AC7FC13", Nom = "Gray", Prenom = "Nevada",
                  Email = "nunc.sit.amet@lectuspede.net", NombreCommande = 20, PointsFidelite = 367,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "928FF82B-193B-D242-7F52-0E5BAFC1F331", Nom = "Rodgers", Prenom = "Yasir",
                  Email = "convallis.est.vitae@etnetus.edu", NombreCommande = 35, PointsFidelite = 161,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "89C34389-1CF4-444F-AD5B-ECB4BEDF05BA", Nom = "Duke", Prenom = "Bradley",
                  Email = "erat.vel.pede@magna.com", NombreCommande = 43, PointsFidelite = 957,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "C612771E-3DA6-1312-0A62-6465FA185ADB", Nom = "Craft", Prenom = "Paki",
                  Email = "eu@aliquetnecimperdiet.edu", NombreCommande = 1, PointsFidelite = 881,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "A135EE7C-B8FB-4C85-3046-F2667A622CEF", Nom = "Garcia", Prenom = "Abdul",
                  Email = "Quisque.purus.sapien@turpis.co.uk", NombreCommande = 3, PointsFidelite = 383,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "94712438-9043-AEBD-EC86-2896AC0EA100", Nom = "Bender", Prenom = "Ryder",
                  Email = "neque@fermentumarcu.com", NombreCommande = 36, PointsFidelite = 159,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "76E938D1-EF7E-03B0-6CCB-4A97F1E96B2D", Nom = "Battle", Prenom = "Yolanda",
                  Email = "enim@acmattis.net", NombreCommande = 40, PointsFidelite = 163, OptinCommercial = false,
                  Genre = "Homme"
              },
              new
              {
                  Id = "5511658A-0296-754E-3A67-7FD6BA71A106", Nom = "Hines", Prenom = "Minerva",
                  Email = "elit.Etiam@aliquetmagna.net", NombreCommande = 28, PointsFidelite = 326,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "733BFA71-7745-43AB-AA05-57CB51CCF7DE", Nom = "Rogers", Prenom = "Shea",
                  Email = "vel.convallis.in@dolorQuisquetincidunt.co.uk", NombreCommande = 32, PointsFidelite = 675,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "AF490A1A-F9BD-DA9B-FEB6-E10AF2BA8815", Nom = "Trujillo", Prenom = "Ishmael",
                  Email = "hendrerit@turpisAliquamadipiscing.ca", NombreCommande = 3, PointsFidelite = 600,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "A95BBC22-E64E-E559-8B49-1CE76018EBF4", Nom = "Kent", Prenom = "Rudyard",
                  Email = "ipsum.sodales.purus@DonecestNunc.com", NombreCommande = 25, PointsFidelite = 377,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "E701BC33-71FF-E9E3-6897-08EF60D13996", Nom = "Booth", Prenom = "Zenia",
                  Email = "egestas.hendrerit@Aeneansedpede.ca", NombreCommande = 2, PointsFidelite = 422,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "2F616FD1-53F5-D46D-4E68-22C0124A8B32", Nom = "Turner", Prenom = "Blythe",
                  Email = "placerat@mauris.com", NombreCommande = 45, PointsFidelite = 803, OptinCommercial = false,
                  Genre = "Homme"
              },
              new
              {
                  Id = "0DDEA076-28F5-FA24-8933-89E0180EDB4B", Nom = "Marquez", Prenom = "Oleg",
                  Email = "augue.ac.ipsum@augueutlacus.ca", NombreCommande = 6, PointsFidelite = 591,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "54CEFB1C-2E2F-B757-A1CC-96E0781675C2", Nom = "Matthews", Prenom = "Porter",
                  Email = "semper.Nam@antelectusconvallis.com", NombreCommande = 13, PointsFidelite = 902,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "7B5BBCD0-4B6B-09AD-1258-1F04831AC80F", Nom = "Levy", Prenom = "Peter",
                  Email = "amet@nislQuisque.com", NombreCommande = 33, PointsFidelite = 196, OptinCommercial = true,
                  Genre = "Femme"
              },
              new
              {
                  Id = "E1AA2F2E-0691-31F2-CC6C-C48BEA2DEC40", Nom = "Wilkinson", Prenom = "Perry",
                  Email = "sit@Duissitamet.ca", NombreCommande = 28, PointsFidelite = 481, OptinCommercial = false,
                  Genre = "Homme"
              },
              new
              {
                  Id = "2F4AF236-F703-A818-687D-7C44CC6959F3", Nom = "Lamb", Prenom = "Cherokee",
                  Email = "eu@cursus.co.uk", NombreCommande = 42, PointsFidelite = 270, OptinCommercial = true,
                  Genre = "Homme"
              },
              new
              {
                  Id = "EE3673D8-EACD-1249-FCE4-305C76F40990", Nom = "Howell", Prenom = "Callum",
                  Email = "senectus.et@at.edu", NombreCommande = 50, PointsFidelite = 653, OptinCommercial = true,
                  Genre = "Femme"
              },
              new
              {
                  Id = "5182D4B2-FB2E-0715-637E-BB5272F907D8", Nom = "Henson", Prenom = "Caesar",
                  Email = "pede@condimentum.net", NombreCommande = 27, PointsFidelite = 525, OptinCommercial = true,
                  Genre = "Homme"
              },
              new
              {
                  Id = "B27AEE63-6A09-8001-BBAE-C80577C6485B", Nom = "Armstrong", Prenom = "Jack",
                  Email = "magnis.dis.parturient@ligulaelitpretium.co.uk", NombreCommande = 45, PointsFidelite = 381,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "98E8FA3B-5333-BDEE-BB8A-90CD2D16CF8B", Nom = "Weber", Prenom = "Jerry",
                  Email = "eget@luctusetultrices.co.uk", NombreCommande = 17, PointsFidelite = 873,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "EF455912-0166-6E99-6189-D7E44178CBCC", Nom = "Diaz", Prenom = "August",
                  Email = "semper.Nam@sit.org", NombreCommande = 24, PointsFidelite = 457, OptinCommercial = false,
                  Genre = "Homme"
              },
              new
              {
                  Id = "CD2AA209-8F40-C54C-DA7B-D70792DD221E", Nom = "Brown", Prenom = "Caleb",
                  Email = "mi@natoque.ca", NombreCommande = 50, PointsFidelite = 420, OptinCommercial = false,
                  Genre = "Homme"
              },
              new
              {
                  Id = "F6224000-0D95-A850-40D6-A2327EABD05F", Nom = "Mejia", Prenom = "Brandon",
                  Email = "sed.sapien@nulla.net", NombreCommande = 44, PointsFidelite = 485, OptinCommercial = false,
                  Genre = "Femme"
              },
              new
              {
                  Id = "14156994-73E1-DEA9-D6BA-882C3C07AD89", Nom = "Schneider", Prenom = "Sawyer",
                  Email = "blandit@metus.org", NombreCommande = 34, PointsFidelite = 926, OptinCommercial = true,
                  Genre = "Homme"
              },
              new
              {
                  Id = "9434B421-E36B-59ED-2430-69E6D6C2249D", Nom = "Mcfarland", Prenom = "Neve",
                  Email = "facilisis@rhoncusDonec.ca", NombreCommande = 1, PointsFidelite = 836,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "108DC8DD-2810-F5B7-6C55-41E4B7D7E775", Nom = "Johnson", Prenom = "Bevis",
                  Email = "eget.varius.ultrices@nequenonquam.com", NombreCommande = 38, PointsFidelite = 143,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "43D04C4C-C4C6-40EA-8EA6-38DC032511C5", Nom = "Wynn", Prenom = "Holmes",
                  Email = "Integer.mollis.Integer@euismodurna.com", NombreCommande = 45, PointsFidelite = 667,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "980F86BA-8CFD-F822-7C01-FEE8831822D6", Nom = "Knapp", Prenom = "Eagan",
                  Email = "ac.ipsum@eratvel.co.uk", NombreCommande = 12, PointsFidelite = 805,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "80A1C9E7-76DD-82DE-96BD-19166DC5591D", Nom = "Robles", Prenom = "Troy",
                  Email = "enim.sit.amet@Quisque.net", NombreCommande = 24, PointsFidelite = 398,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "9F08E90E-0C73-3650-413A-04E1194C68B8", Nom = "Whitfield", Prenom = "Raymond",
                  Email = "nunc@cursusdiamat.org", NombreCommande = 28, PointsFidelite = 87, OptinCommercial = false,
                  Genre = "Homme"
              },
              new
              {
                  Id = "23CD0BF1-1988-3B70-A55D-F3944B00E114", Nom = "Greer", Prenom = "Clementine",
                  Email = "nibh.dolor.nonummy@blanditenim.edu", NombreCommande = 11, PointsFidelite = 182,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "943235CE-7346-3E1C-F764-1BE023B38264", Nom = "Warren", Prenom = "Graiden",
                  Email = "a.nunc@nullamagnamalesuada.net", NombreCommande = 32, PointsFidelite = 338,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "604C5F27-3CC2-4DAC-5976-D318F897FE68", Nom = "Park", Prenom = "Germane",
                  Email = "ante@ultricesmauris.org", NombreCommande = 45, PointsFidelite = 376,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "683FA2FA-ED56-41B4-ABB4-AC9E029249B8", Nom = "Mckinney", Prenom = "Merritt",
                  Email = "tortor@tempus.org", NombreCommande = 15, PointsFidelite = 780, OptinCommercial = true,
                  Genre = "Homme"
              },
              new
              {
                  Id = "B8C58E20-FE53-BA75-C782-36320DC641C2", Nom = "Burris", Prenom = "Catherine",
                  Email = "volutpat@nonfeugiatnec.org", NombreCommande = 9, PointsFidelite = 400,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "45A6E655-E423-4C83-6865-E30D0247C297", Nom = "Pickett", Prenom = "Madaline",
                  Email = "sem.Nulla.interdum@eget.org", NombreCommande = 39, PointsFidelite = 881,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "857F3B6D-A5D9-0876-CAB6-CF73CC26C9CD", Nom = "Singleton", Prenom = "Jolie",
                  Email = "id.nunc@commodoipsumSuspendisse.com", NombreCommande = 37, PointsFidelite = 506,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "F6068396-FD3C-BEC7-F4F9-14EC3ACC734B", Nom = "Blevins", Prenom = "Delilah",
                  Email = "dignissim.magna.a@loremegetmollis.edu", NombreCommande = 23, PointsFidelite = 712,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "BCE61A5D-10C9-AA0C-BB74-E68B083D0063", Nom = "Valenzuela", Prenom = "Helen",
                  Email = "elit@non.com", NombreCommande = 24, PointsFidelite = 229, OptinCommercial = false,
                  Genre = "Femme"
              },
              new
              {
                  Id = "3E2222C6-7BA8-D914-C753-2420C2C636E0", Nom = "Mclean", Prenom = "Jared",
                  Email = "suscipit.est.ac@loremac.ca", NombreCommande = 11, PointsFidelite = 462,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "823EF357-C879-EF13-FCD7-8F519FF983F5", Nom = "Cabrera", Prenom = "Amaya",
                  Email = "non.dui.nec@arcuacorci.com", NombreCommande = 15, PointsFidelite = 914,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "02F0857C-AE47-2B40-A5FE-97A9CFFA48DD", Nom = "Mcfarland", Prenom = "Bianca",
                  Email = "Integer.sem@congue.net", NombreCommande = 16, PointsFidelite = 883, OptinCommercial = true,
                  Genre = "Femme"
              },
              new
              {
                  Id = "9C910FD2-2C7B-00A2-4DB4-EECFDB786EF7", Nom = "Beasley", Prenom = "Charlotte",
                  Email = "in@id.edu", NombreCommande = 25, PointsFidelite = 882, OptinCommercial = true,
                  Genre = "Femme"
              },
              new
              {
                  Id = "C5E45161-10CE-815F-6E56-B43010BCCE51", Nom = "Ratliff", Prenom = "Brett",
                  Email = "risus.at.fringilla@arcu.co.uk", NombreCommande = 27, PointsFidelite = 919,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "7DD25343-1C2D-7997-1D11-2901C82FC35A", Nom = "Medina", Prenom = "Sydnee",
                  Email = "et.netus@urnaNullamlobortis.net", NombreCommande = 28, PointsFidelite = 328,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "52CD4520-44FE-C6C6-788D-74612B259386", Nom = "Huff", Prenom = "Tamekah",
                  Email = "ullamcorper.Duis.cursus@tortor.ca", NombreCommande = 49, PointsFidelite = 896,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "BA6D5A37-B20A-9359-7B80-5A4447BE2457", Nom = "Knight", Prenom = "Jenette",
                  Email = "cubilia.Curae.Donec@nibhAliquamornare.org", NombreCommande = 47, PointsFidelite = 792,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "C35662A9-65A9-A475-CE93-F59FB033CF78", Nom = "Peterson", Prenom = "Walter",
                  Email = "Curabitur.ut.odio@nequeetnunc.org", NombreCommande = 33, PointsFidelite = 765,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "AF83482E-E067-98AC-2315-58CD9295263D", Nom = "Anthony", Prenom = "Ashton",
                  Email = "elit@eueuismodac.edu", NombreCommande = 22, PointsFidelite = 117, OptinCommercial = true,
                  Genre = "Homme"
              },
              new
              {
                  Id = "4753423C-CE70-FA7D-37F3-47D837127174", Nom = "Robbins", Prenom = "Ronan",
                  Email = "Aliquam.erat@Aenean.ca", NombreCommande = 35, PointsFidelite = 747,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "7FF18480-BC82-2A37-D3DB-96BCF0746BE7", Nom = "Webster", Prenom = "Malcolm",
                  Email = "arcu.imperdiet.ullamcorper@posuere.co.uk", NombreCommande = 44, PointsFidelite = 932,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "06BCA9F7-CAF4-F603-434E-31F69625B993", Nom = "Baxter", Prenom = "Liberty",
                  Email = "Nunc@nec.co.uk", NombreCommande = 3, PointsFidelite = 882, OptinCommercial = true,
                  Genre = "Homme"
              },
              new
              {
                  Id = "1D80C45D-DB30-1E3E-6E73-08F82AB78B57", Nom = "Gregory", Prenom = "Caryn", Email = "nibh@a.ca",
                  NombreCommande = 6, PointsFidelite = 154, OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "5F4FA3D7-4635-358B-DA4B-7A8FA2119F19", Nom = "Tanner", Prenom = "Nero",
                  Email = "nibh@Nunc.co.uk", NombreCommande = 7, PointsFidelite = 610, OptinCommercial = true,
                  Genre = "Homme"
              },
              new
              {
                  Id = "29C04327-E1BB-9C6C-CCEF-52C05F642F4D", Nom = "Evans", Prenom = "Warren",
                  Email = "Donec.tempus@natoque.co.uk", NombreCommande = 5, PointsFidelite = 256,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "549F79D6-AB9F-CCF9-E93D-EBE58CCC763F", Nom = "Barlow", Prenom = "Harlan",
                  Email = "luctus.ut.pellentesque@odio.net", NombreCommande = 40, PointsFidelite = 596,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "FE08F48B-39A3-AC1B-5DFF-4178F691AFD9", Nom = "Cannon", Prenom = "Oliver",
                  Email = "viverra.Maecenas.iaculis@magna.ca", NombreCommande = 36, PointsFidelite = 720,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "C08BA6C9-EC8D-9225-698E-B892D13FFEA1", Nom = "Miranda", Prenom = "Samson",
                  Email = "nibh.enim.gravida@sagittisDuisgravida.ca", NombreCommande = 41, PointsFidelite = 972,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "5E32BE5C-D244-E776-D84C-A9419482BC6B", Nom = "Summers", Prenom = "Vivian",
                  Email = "quis@liberoDonec.org", NombreCommande = 8, PointsFidelite = 216, OptinCommercial = false,
                  Genre = "Femme"
              },
              new
              {
                  Id = "57056CC9-6595-6AE1-A8A6-76A8B500DC75", Nom = "Barker", Prenom = "Oscar",
                  Email = "sem@vitaeeratvel.ca", NombreCommande = 31, PointsFidelite = 972, OptinCommercial = true,
                  Genre = "Femme"
              },
              new
              {
                  Id = "5ED798C4-BA57-A20E-D48E-B85DD8FD6746", Nom = "Castillo", Prenom = "Uriel",
                  Email = "urna@ultrices.org", NombreCommande = 24, PointsFidelite = 925, OptinCommercial = true,
                  Genre = "Homme"
              },
              new
              {
                  Id = "006BF748-314A-79A7-ECF9-2CE3181A6FB2", Nom = "Foreman", Prenom = "Julie",
                  Email = "sociis@sedturpis.ca", NombreCommande = 19, PointsFidelite = 695, OptinCommercial = false,
                  Genre = "Femme"
              },
              new
              {
                  Id = "C7E528D8-0959-8461-3111-A42C3DA70044", Nom = "Hogan", Prenom = "Walter",
                  Email = "tristique@Cumsociisnatoque.co.uk", NombreCommande = 36, PointsFidelite = 509,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "4F5FDDCC-C179-7F9C-B0B5-0AA441472760", Nom = "Mckenzie", Prenom = "Dominique",
                  Email = "nonummy@nec.com", NombreCommande = 28, PointsFidelite = 273, OptinCommercial = false,
                  Genre = "Homme"
              },
              new
              {
                  Id = "8EF4F7B2-9BFF-7216-EDA6-F29CAF2F5DE1", Nom = "Daugherty", Prenom = "Scott",
                  Email = "Nunc.ut.erat@aenim.co.uk", NombreCommande = 30, PointsFidelite = 970,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "DE36C05A-021E-0B8D-DC7F-1FADF6E2251D", Nom = "Kline", Prenom = "April",
                  Email = "mauris.erat.eget@fringilla.co.uk", NombreCommande = 41, PointsFidelite = 210,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "44D81B51-79E8-CF67-312D-DC298CF5394D", Nom = "Estrada", Prenom = "Melanie",
                  Email = "feugiat.metus@nonfeugiat.edu", NombreCommande = 2, PointsFidelite = 69,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "C6E68927-43A0-679E-CBDA-6420A08093E7", Nom = "Keith", Prenom = "Ryan",
                  Email = "bibendum.ullamcorper@duilectus.edu", NombreCommande = 5, PointsFidelite = 693,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "9C818CCD-6566-BD15-7CC7-0A56B5911F27", Nom = "Hebert", Prenom = "May",
                  Email = "massa.Suspendisse@vitaesodalesnisi.edu", NombreCommande = 32, PointsFidelite = 912,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "E78B65A3-33B4-B08B-82E5-36A681597A9E", Nom = "Matthews", Prenom = "Steel",
                  Email = "elit@interdumenim.co.uk", NombreCommande = 7, PointsFidelite = 570, OptinCommercial = true,
                  Genre = "Femme"
              },
              new
              {
                  Id = "3BFE4450-AC79-0ACF-AE74-48EEA56A0484", Nom = "Vazquez", Prenom = "Armand",
                  Email = "primis@pulvinararcu.edu", NombreCommande = 23, PointsFidelite = 247,
                  OptinCommercial = true, Genre = "Femme"
              },
              new
              {
                  Id = "2DEE1E67-1DF9-98A9-7147-C0AA27B89019", Nom = "Tyler", Prenom = "Mason",
                  Email = "imperdiet.nec@iaculisodio.edu", NombreCommande = 33, PointsFidelite = 813,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "F4062B88-6645-3B8E-F25B-21F54EDD0899", Nom = "Odom", Prenom = "Amaya",
                  Email = "dolor.egestas.rhoncus@loremtristique.com", NombreCommande = 34, PointsFidelite = 110,
                  OptinCommercial = false, Genre = "Homme"
              },
              new
              {
                  Id = "9958C7EF-818B-3CCD-65EC-32AC8F8F91A3", Nom = "Knapp", Prenom = "Britanni",
                  Email = "non@nibh.co.uk", NombreCommande = 48, PointsFidelite = 80, OptinCommercial = true,
                  Genre = "Homme"
              },
              new
              {
                  Id = "C2A2A2CC-49A2-2CA4-3053-6EDA0FC353E3", Nom = "Conner", Prenom = "Eliana",
                  Email = "tellus.id@Maurisnulla.net", NombreCommande = 24, PointsFidelite = 994,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "0663B637-25C4-B81E-6BC9-A8DDFF13A918", Nom = "Estes", Prenom = "Wing",
                  Email = "ullamcorper.magna.Sed@lorem.com", NombreCommande = 47, PointsFidelite = 200,
                  OptinCommercial = true, Genre = "Homme"
              },
              new
              {
                  Id = "C1FA923A-2606-E66A-EC6B-EC91BB9701DD", Nom = "Mcpherson", Prenom = "Carter",
                  Email = "ligula@ac.edu", NombreCommande = 28, PointsFidelite = 564, OptinCommercial = false,
                  Genre = "Homme"
              },
              new
              {
                  Id = "2422375D-2503-B3DB-60C3-050C13B8812E", Nom = "Cleveland", Prenom = "Malachi",
                  Email = "imperdiet@euerat.net", NombreCommande = 35, PointsFidelite = 743, OptinCommercial = false,
                  Genre = "Femme"
              },
              new
              {
                  Id = "9C81AA37-6BAE-A4B9-7A68-4E94DC7A581A", Nom = "Henderson", Prenom = "Carter",
                  Email = "In.mi@et.net", NombreCommande = 19, PointsFidelite = 638, OptinCommercial = false,
                  Genre = "Femme"
              },
              new
              {
                  Id = "6E0FA74A-43FA-C7B6-607A-9B854F2F0442", Nom = "Cleveland", Prenom = "Kylie",
                  Email = "neque.Nullam@enim.org", NombreCommande = 35, PointsFidelite = 581, OptinCommercial = false,
                  Genre = "Homme"
              },
              new
              {
                  Id = "B3B5665B-6DC8-4C16-CF17-903A13398BEC", Nom = "Holmes", Prenom = "Rogan",
                  Email = "lobortis@orci.co.uk", NombreCommande = 43, PointsFidelite = 689, OptinCommercial = false,
                  Genre = "Femme"
              },
              new
              {
                  Id = "EE5FFB07-1C70-1809-0071-3C9551274424", Nom = "Solis", Prenom = "Cedric",
                  Email = "enim.Etiam.imperdiet@etcommodoat.org", NombreCommande = 45, PointsFidelite = 835,
                  OptinCommercial = false, Genre = "Femme"
              },
              new
              {
                  Id = "44863DDD-B315-8281-5EB7-C1F1744252FC", Nom = "Harding", Prenom = "Herrod",
                  Email = "Proin.vel@Sedmalesuadaaugue.net", NombreCommande = 8, PointsFidelite = 910,
                  OptinCommercial = false, Genre = "Homme"
              }
            };

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Exercice 2.1");
            IEnumerable<Person> v_persons = data
                .Where(p_obj => p_obj.Nom.StartsWith('D'))
                .Select(p_obj => new Person(p_obj.Prenom, p_obj.Nom, p_obj.NombreCommande, p_obj.PointsFidelite));
            v_persons.ToList().ForEach(p_person => Console.WriteLine(p_person));

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Exercice 2.2");
            int v_maxCommand = data.Max(p_obj => p_obj.NombreCommande);
            var v_person = data.First(p_obj => p_obj.NombreCommande == v_maxCommand);
            Console.WriteLine(new Person(v_person.Prenom, v_person.Nom, v_person.NombreCommande, v_person.PointsFidelite));

            // Deuxième méthode avec une boucle
            v_person = data.OrderByDescending(p_obj => p_obj.NombreCommande).First();
            Console.WriteLine(new Person(v_person.Prenom, v_person.Nom, v_person.NombreCommande, v_person.PointsFidelite));

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Exercice 2.3");
            v_persons = data
                .OrderByDescending(p_obj => p_obj.PointsFidelite)
                .Take(5)
                .Select(p_obj => new Person(p_obj.Prenom, p_obj.Nom, p_obj.NombreCommande, p_obj.PointsFidelite));
            v_persons.ToList().ForEach(p_person => Console.WriteLine(p_person));

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Exercice 2.4");
            var v_averages = data
                .GroupBy(p_obj => p_obj.Genre)
                .Select(p_grp => new { p_grp.Key , Average = p_grp.Average(p_obj => p_obj.NombreCommande) });
            foreach (var v_average in v_averages)
            {
                Console.WriteLine($"Genre : {v_average.Key}, Average : {v_average.Average}");
            }
        }
    }
}
