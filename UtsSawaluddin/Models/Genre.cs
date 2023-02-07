namespace UtsSawaluddin.Models
{
    public class Genre
    {
        public JudulBuku JudulBuku { get; set; }

        public Genre (JudulBuku judulBuku)
        {
            JudulBuku = judulBuku;
        }
        public string GenreBook
        {
            get
            {
                string genre = "";
                if (JudulBuku == JudulBuku.KomikBlackClover || JudulBuku == JudulBuku.KomikOnePiece || JudulBuku == JudulBuku.KomikJujutsuKaisen)
                {
                    genre = "Komik";
                }
                else if (JudulBuku == JudulBuku.NovelAndreaHirata || JudulBuku == JudulBuku.NovelJKRowling || JudulBuku == JudulBuku.NovelTereLiye)
                {
                    genre = "Novel";
                }
                else if (JudulBuku == JudulBuku.SejarahIndonesia || JudulBuku == JudulBuku.SejarahYunani || JudulBuku == JudulBuku.SejarahJepang)
                {
                    genre = "Sejarah";
                }
                return genre;
            }
        }
    }

    
}
