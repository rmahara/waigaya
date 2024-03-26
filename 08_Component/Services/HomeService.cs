using _08_Component.Controllers.Response;

namespace _08_Component.Services
{
    public class HomeService : IHomeService
    {
        public HomeResponse Get()
        {
            var response = new HomeResponse();

            response.Movies = new(){
                new () { Id = 1, Title = "カールじいさんの空飛ぶ家" },
                new () { Id = 2, Title = "天使にラブソングを…" },
                new () { Id = 3, Title = "千と千尋の神隠し"},
                new () { Id = 4, Title = "ハムナプトラ"},
                new () { Id = 5, Title = "アナと雪の女王"},
                new () { Id = 6, Title = "きっと、うまくいく"},
            };

            response.Books = new() {
                new () { Id = 1, Title = "リーダブルコード" },
                new () { Id = 2, Title = "Webデザインとコーディングのきほんのきほん" },
                new () { Id = 3, Title = "Webを支える技術" },
                new () { Id = 4, Title = "SEの基本　この１冊ですべてわかる" },
                new () { Id = 5, Title = "はじめての上流工程をやり抜くための本" },
                new () { Id = 6, Title = "ネットワークはなぜつながるのか" },
            };

            return response;
        }
    }
}
