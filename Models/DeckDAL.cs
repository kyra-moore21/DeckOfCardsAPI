using Microsoft.AspNetCore.DataProtection;
using System.Net;
using Newtonsoft.Json;

namespace DeckOfCardsAPI.Models
{
    public class DeckDAL
    {
        public static CardsModel GetCards() //Adjust
        {
            //adjust
            //setup
            string url = $"https://deckofcardsapi.com/api/deck/{DeckID.ID}/draw/?count=5";
            //hide API key from github at end 
            //request leave alone
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //get response leave alone
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust 
            //Convert to C#
            //Install Newtonsoft.Json nugget package
            CardsModel result = JsonConvert.DeserializeObject<CardsModel>(JSON);
            return result;
        }
        public static CardsModel Shuffle()
        {
            string url = $"https://deckofcardsapi.com/api/deck/{DeckID.ID}/shuffle/";
            //hide API key from github at end 
            //request leave alone
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //get response leave alone
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust 
            //Convert to C#
            //Install Newtonsoft.Json nugget package
            CardsModel result = JsonConvert.DeserializeObject<CardsModel>(JSON);
            return result;
        }
       
    }
}
