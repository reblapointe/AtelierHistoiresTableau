namespace AtelierHistoiresTableau
{
    class AtelierHistoiresTableau
    {
        static void Main(string[] args)
        {
            Random random = new ();

            string[] personnages =
            {
                "une fée",
                "un dragon",
                "un spectre",
                "Jimmy Maltais",
                "le père Noël",
                "le Premier Ministre"
            };

            string[] etats =
            {
                "endormi(e)",
                "sur l'acide",
                "en bobettes",
                "avec une épée",
                "enragé(e)"
            };

            string[] endroits =
            {
                "dans la salle d'agilité",
                "sur le toit du Cégep",
                "au beau milieu d'un champ de blé d'Inde",
                "sur la Saint-Dominique",
                "dans le confessionnal",
                "en dessous de la table",
                "dans le parc des Laurentides"
            };

            // Pour piger un nombre au hasard entre 0 (inclu) et 10 (exclu)
            int h = random.Next(10);

            /* ... */
        }
    }
}