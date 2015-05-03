using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Runtime.Serialization.Json;
using System.Json;

namespace Desafio_Geoambiente.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Consulta de Shots Dribbble.";

            var json = GetJson();

            dynamic jsonTratado = JsonValue.Parse(json);

            string Id0      = jsonTratado.shots[0].id;
            string title0   = jsonTratado.shots[0].title;
            string Image0   = jsonTratado.shots[0].image_teaser_url;
            string Url0     = jsonTratado.shots[0].url;
            string Views0   = jsonTratado.shots[0].views_count;
            string Avatar0  = jsonTratado.shots[0].player.avatar_url;
            string Name0    = jsonTratado.shots[0].player.name;
            string Desc0    = jsonTratado.shots[0].description;

            string Id1      = jsonTratado.shots[1].id;
            string title1   = jsonTratado.shots[1].title;
            string Image1   = jsonTratado.shots[1].image_teaser_url;
            string Url1     = jsonTratado.shots[1].url;
            string Views1   = jsonTratado.shots[1].views_count;
            string Avatar1  = jsonTratado.shots[1].player.avatar_url;
            string Name1    = jsonTratado.shots[1].player.name;
            string Desc1    = jsonTratado.shots[1].description;

            string Id2      = jsonTratado.shots[2].id;
            string title2   = jsonTratado.shots[2].title;
            string Image2   = jsonTratado.shots[2].image_teaser_url;
            string Url2     = jsonTratado.shots[2].url;
            string Views2   = jsonTratado.shots[2].views_count;
            string Avatar2  = jsonTratado.shots[2].player.avatar_url;
            string Name2    = jsonTratado.shots[2].player.name;
            string Desc2    = jsonTratado.shots[2].description;

            ViewBag.Id0     = Id0;
            ViewBag.title0  = title0;
            ViewBag.Image0  = Image0;
            ViewBag.Url0    = Url0;
            ViewBag.Views0  = Views0;
            ViewBag.Avatar0 = Avatar0;
            ViewBag.Name0   = Name0;
            ViewBag.Desc0   = Desc0;

            ViewBag.Id1     = Id1;
            ViewBag.title1  = title1;
            ViewBag.Image1  = Image1;
            ViewBag.Url1    = Url1;
            ViewBag.Views1 = Views1;
            ViewBag.Avatar1 = Avatar1;
            ViewBag.Name1 = Name1;
            ViewBag.Desc1 = Desc1;

            ViewBag.Id2     = Id2;
            ViewBag.title2  = title2;
            ViewBag.Image2  = Image2;
            ViewBag.Url2    = Url2;
            ViewBag.Views2 = Views2;
            ViewBag.Avatar2 = Avatar2;
            ViewBag.Name2 = Name2;
            ViewBag.Desc2 = Desc2;

            return View();
        }

        private string GetJson()
        {
            string jsonString = "{";
            jsonString += "\"page\": \"1\",";
            jsonString += "\"per_page\": 15,";
            jsonString += "\"pages\": 50,";
            jsonString += "\"total\": 750,";
            jsonString += "\"shots\": [";
            jsonString += "{";
            jsonString += "\"id\": 2044729,";
            jsonString += "\"title\": \"Who run barter town?\",";
            jsonString += "\"description\": \"Patiently waiting for my face to melt off.\",";
            jsonString += "\"height\": 600,";
            jsonString += "\"width\": 800,";
            jsonString += "\"likes_count\": 243,";
            jsonString += "\"comments_count\": 13,";
            jsonString += "\"rebounds_count\": 0,";
            jsonString += "\"url\": \"http://dribbble.com/shots/2044729-Who-run-barter-town\",";
            jsonString += "\"short_url\": \"http://drbl.in/oCjL\",";
            jsonString += "\"views_count\": 1230,";
            jsonString += "\"rebound_source_id\": null,";
            jsonString += "\"image_url\": \"https://d13yacurqjgara.cloudfront.net/users/108083/screenshots/2044729/furyroad_800x600.jpg\",";
            jsonString += "\"image_teaser_url\": \"https://d13yacurqjgara.cloudfront.net/users/108083/screenshots/2044729/furyroad_800x600_teaser.jpg\",";
            jsonString += "\"image_400_url\": \"https://d13yacurqjgara.cloudfront.net/users/108083/screenshots/2044729/furyroad_800x600_1x.jpg\",";
            jsonString += "\"player\": {";
            jsonString += "\"id\": 108083,";
            jsonString += "\"name\": \"Philip Eggleston\",";
            jsonString += "\"location\": \"Minneapolis\",";
            jsonString += "\"followers_count\": 2425,";
            jsonString += "\"draftees_count\": 4,";
            jsonString += "\"likes_count\": 17230,";
            jsonString += "\"likes_received_count\": 7336,";
            jsonString += "\"comments_count\": 1281,";
            jsonString += "\"comments_received_count\": 807,";
            jsonString += "\"rebounds_count\": 14,";
            jsonString += "\"rebounds_received_count\": 17,";
            jsonString += "\"url\": \"http://dribbble.com/peggleston\",";
            jsonString += "\"avatar_url\": \"https://d13yacurqjgara.cloudfront.net/users/108083/avatars/normal/PippyAvatar.jpg?1373832576\",";
            jsonString += "\"username\": \"peggleston\",";
            jsonString += "\"twitter_screen_name\": null,";
            jsonString += "\"website_url\": \"http://www.peggleston.com\",";
            jsonString += "\"drafted_by_player_id\": 26356,";
            jsonString += "\"shots_count\": 77,";
            jsonString += "\"following_count\": 1388,";
            jsonString += "\"created_at\": \"2012/02/25 22:27:55 -0500\"";
            jsonString += "},";
            jsonString += "\"created_at\": \"2015/05/01 10:57:32 -0400\"";
            jsonString += "},";
            jsonString += "{";
            jsonString += "\"id\": 2044780,";
            jsonString += "\"title\": \"Landscape Project\",";
            jsonString += "\"description\": null,";
            jsonString += "\"height\": 600,";
            jsonString += "\"width\": 800,";
            jsonString += "\"likes_count\": 216,";
            jsonString += "\"comments_count\": 11,";
            jsonString += "\"rebounds_count\": 0,";
            jsonString += "\"url\": \"http://dribbble.com/shots/2044780-Landscape-Project\",";
            jsonString += "\"short_url\": \"http://drbl.in/oCkK\",";
            jsonString += "\"views_count\": 1175,";
            jsonString += "\"rebound_source_id\": null,";
            jsonString += "\"image_url\": \"https://d13yacurqjgara.cloudfront.net/users/60166/screenshots/2044780/landscape_project.jpg\",";
            jsonString += "\"image_teaser_url\": \"https://d13yacurqjgara.cloudfront.net/users/60166/screenshots/2044780/landscape_project_teaser.jpg\",";
            jsonString += "\"image_400_url\": \"https://d13yacurqjgara.cloudfront.net/users/60166/screenshots/2044780/landscape_project_1x.jpg\",";
            jsonString += "\"player\": {";
            jsonString += "\"id\": 60166,";
            jsonString += "\"name\": \"Yoga Perdana\",";
            jsonString += "\"location\": \"Indonesia\",";
            jsonString += "\"followers_count\": 18832,";
            jsonString += "\"draftees_count\": 5,";
            jsonString += "\"likes_count\": 9538,";
            jsonString += "\"likes_received_count\": 76559,";
            jsonString += "\"comments_count\": 1963,";
            jsonString += "\"comments_received_count\": 3063,";
            jsonString += "\"rebounds_count\": 7,";
            jsonString += "\"rebounds_received_count\": 37,";
            jsonString += "\"url\": \"http://dribbble.com/yoga\",";
            jsonString += "\"avatar_url\": \"https://d13yacurqjgara.cloudfront.net/users/60166/avatars/normal/yogaLogo.png?1390870645\",";
            jsonString += "\"username\": \"yoga\",";
            jsonString += "\"twitter_screen_name\": \"yoga7\",";
            jsonString += "\"website_url\": \"http://yogaportfolio.tumblr.com\",";
            jsonString += "\"drafted_by_player_id\": 32388,";
            jsonString += "\"shots_count\": 184,";
            jsonString += "\"following_count\": 1192,";
            jsonString += "\"created_at\": \"2011/09/07 07:10:00 -0400\"";
            jsonString += "},";
            jsonString += "\"created_at\": \"2015/05/01 11:28:53 -0400\"";
            jsonString += "},";
            jsonString += "{";
            jsonString += "\"id\": 2045026,";
            jsonString += "\"title\": \"Gift Card\",";
            jsonString += "\"description\": \"Express gift card shopping in one click, just buy it~\",";
            jsonString += "\"height\": 600,";
            jsonString += "\"width\": 800,";
            jsonString += "\"likes_count\": 231,";
            jsonString += "\"comments_count\": 13,";
            jsonString += "\"rebounds_count\": 0,";
            jsonString += "\"url\": \"http://dribbble.com/shots/2045026-Gift-Card\",";
            jsonString += "\"short_url\": \"http://drbl.in/oCpw\",";
            jsonString += "\"views_count\": 1582,";
            jsonString += "\"rebound_source_id\": null,";
            jsonString += "\"image_url\": \"https://d13yacurqjgara.cloudfront.net/users/142295/screenshots/2045026/giftcard.gif\",";
            jsonString += "\"image_teaser_url\": \"https://d13yacurqjgara.cloudfront.net/users/142295/screenshots/2045026/giftcard_teaser.gif\",";
            jsonString += "\"image_400_url\": \"https://d13yacurqjgara.cloudfront.net/users/142295/screenshots/2045026/giftcard_1x.gif\",";
            jsonString += "\"player\": {";
            jsonString += "\"id\": 142295,";
            jsonString += "\"name\": \"Chuan²\",";
            jsonString += "\"location\": null,";
            jsonString += "\"followers_count\": 4342,";
            jsonString += "\"draftees_count\": 5,";
            jsonString += "\"likes_count\": 406,";
            jsonString += "\"likes_received_count\": 11851,";
            jsonString += "\"comments_count\": 146,";
            jsonString += "\"comments_received_count\": 856,";
            jsonString += "\"rebounds_count\": 2,";
            jsonString += "\"rebounds_received_count\": 7,";
            jsonString += "\"url\": \"http://dribbble.com/woodmouse\",";
            jsonString += "\"avatar_url\": \"https://d13yacurqjgara.cloudfront.net/users/142295/avatars/normal/meiconmov2.jpg?1362588979\",";
            jsonString += "\"username\": \"woodmouse\",";
            jsonString += "\"twitter_screen_name\": null,";
            jsonString += "\"website_url\": \"http://weibo.com/mulaoshu\",";
            jsonString += "\"drafted_by_player_id\": 46375,";
            jsonString += "\"shots_count\": 34,";
            jsonString += "\"following_count\": 194,";
            jsonString += "\"created_at\": \"2012/05/04 07:19:34 -0400\"";
            jsonString += "},";
            jsonString += "\"created_at\": \"2015/05/01 14:14:38 -0400\"";
            jsonString += "}";
            jsonString += "]";
            jsonString += "}";

            return jsonString;
        }
    }
}
