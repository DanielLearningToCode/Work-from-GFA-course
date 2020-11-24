namespace ChatApp.Models
{
    public class Author
    {
        private string avatarUrl;
        public string UserName { get; set; }
        public int UserId { get; set; }

        public string Avatarurl
        {
            get
            {
                return avatarUrl;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    avatarUrl = "https://www.kbxmedia.cz/data/clanky/800x600a/james-cameron-planuje-s-avatarem-2-sesadit-z-komercniho-truny-posledni-avengery.jpg";
                }
                else
                {
                    avatarUrl = value;
                }
            }
        }
        public Author()
        {
            Avatarurl = avatarUrl;
        }

    }
}
