
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TravelBlog2nd
{
    [Activity(Label = "CountryInfoActivity")]
    public class CountryInfoActivity : Activity
    {
        List<TableItem> tableItems = new List<TableItem>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.country_detail_info);

            string cityName = Intent.GetStringExtra("city_name") ?? "Data not available";

            initializeData();

            ImageView imgView = FindViewById<ImageView>(Resource.Id.imageView1);
            EditText editTxt = FindViewById<EditText>(Resource.Id.editText1);
            EditText editTxt2 = FindViewById<EditText>(Resource.Id.editText2);


            foreach (TableItem item in tableItems)
            {
                if (item.Heading == cityName)
                {
                    imgView.SetImageResource(item.ImageResourceId);
                    editTxt.Text = item.Heading;
                    editTxt2.Text = item.Description;

                }
            }


        }

        private void initializeData()
        {
            tableItems.Add(new TableItem()
            {
                Heading = "Seoul",
                SubHeading = "South Korea",
                ImageResourceId = Resource.Drawable.img_south_korea
                                              ,
                Description = "South Korea, an East Asian nation on the southern " +
                                                                "half of the Korean Peninsula, shares one of the world’s " +
                                                                "most heavily militarized borders with North Korea. " +
                                                                "It’s equally known for its green, hilly countryside " +
                                                                "dotted with cherry trees and centuries-old Buddhist temples, " +
                                                                "plus its coastal fishing villages, sub-tropical islands " +
                                                                "and high-tech cities such as Seoul, the capital."
            });
            tableItems.Add(new TableItem()
            {
                Heading = "Toronto",
                SubHeading = "Canada",
                ImageResourceId = Resource.Drawable.img_toronto
                                              ,
                Description = "Toronto, the capital of the province of Ontario, " +
                                                                "is a major Canadian city along Lake Ontario’s northwestern shore. " +
                                                                "It's a dynamic metropolis with a core of soaring skyscrapers, " +
                                                                "all dwarfed by the iconic, free-standing CN Tower. " +
                                                                "Toronto also has many green spaces, from the orderly " +
                                                                "oval of Queen’s Park to 400-acre High Park and its trails, " +
                                                                "sports facilities and zoo."
            });
            tableItems.Add(new TableItem()
            {
                Heading = "Quebec",
                SubHeading = "Canada",
                ImageResourceId = Resource.Drawable.img_quebec
                                              ,
                Description = "Québec City sits on the Saint Lawrence River " +
                                                                "in Canada's mostly French-speaking Québec province. " +
                                                                "Dating to 1608, it has a fortified colonial core, " +
                                                                "Vieux-Québec and Place Royale, with stone buildings " +
                                                                "and narrow streets. This area is the site of the " +
                                                                "towering Château Frontenac Hotel and imposing Citadelle " +
                                                                "of Québec. The Petit Champlain district’s cobblestone streets " +
                                                                "are lined with bistros and boutiques."
            });
            tableItems.Add(new TableItem()
            {
                Heading = "Paris",
                SubHeading = "France",
                ImageResourceId = Resource.Drawable.img_paris
                                                 ,
                Description = "Paris, France's capital, is a major European city " +
                                                                "and a global center for art, fashion, gastronomy and culture. " +
                                                                "Its 19th-century cityscape is crisscrossed by wide boulevards " +
                                                                "and the River Seine. Beyond such landmarks as the Eiffel Tower " +
                                                                "and the 12th-century, Gothic Notre-Dame cathedral, " +
                                                                "the city is known for its cafe culture and designer boutiques " +
                                                                "along the Rue du Faubourg Saint-Honoré."
            });
            tableItems.Add(new TableItem()
            {
                Heading = "Rome",
                SubHeading = "Italy",
                ImageResourceId = Resource.Drawable.img_rome
                                                ,
                Description = "Rome, Italy’s capital, is a sprawling, cosmopolitan city with " +
                                                                "nearly 3,000 years of globally influential art, " +
                                                                "architecture and culture on display. Ancient ruins such as" +
                                                                " the Forum and the Colosseum evoke the power of the former Roman Empire. " +
                                                                "Vatican City, headquarters of the Roman Catholic Church, " +
                                                                "has St. Peter’s Basilica and the Vatican Museums, " +
                                                                "which house masterpieces such as Michelangelo’s Sistine Chapel frescoes."
            });
            tableItems.Add(new TableItem()
            {
                Heading = "Lucerne",
                SubHeading = "Switzerland",
                ImageResourceId = Resource.Drawable.img_lucerne
                                                ,
                Description = "Lucerne, a compact city in Switzerland known for its preserved " +
                                                                "medieval architecture, sits amid snowcapped mountains on Lake Lucerne. " +
                                                                "Its colorful Altstadt (Old Town) is bordered on the north by 870m Museggmauer" +
                                                                " (Musegg Wall), a 14-century rampart. " +
                                                                "The covered Kapellbrücke (Chapel Bridge), built in 1333, " +
                                                                "links the Aldstadt to the Reuss River's right bank."
            });

            tableItems.Add(new TableItem()
            {
                Heading = "NewYork",
                SubHeading = "Unite States",
                ImageResourceId = Resource.Drawable.img_usa
                                                ,
                Description = "The U.S. is a country of 50 states covering a vast swath of North America," +
                                                                " with Alaska in the northwest and Hawaii extending the nation’s " +
                                                                "presence into the Pacific Ocean. Major Atlantic Coast cities are New York, " +
                                                                "a global finance and culture center, and capital Washington, DC. " +
                                                                "Midwestern metropolis Chicago is known for influential architecture " +
                                                                "and on the west coast, Los Angeles' Hollywood is famed for filmmaking."
            });
            tableItems.Add(new TableItem()
            {
                Heading = "London",
                SubHeading = "England",
                ImageResourceId = Resource.Drawable.img_london
                                               ,
                Description = "London, the capital of England and the United Kingdom," +
                                                                " is a 21st-century city with history stretching back to Roman times. " +
                                                                "At its centre stand the imposing Houses of Parliament, the iconic ‘Big Ben’ " +
                                                                "clock tower and Westminster Abbey, site of British monarch coronations. " +
                                                                "Across the Thames River, the London Eye observation wheel provides " +
                                                                "panoramic views of the South Bank cultural complex, and the entire city."
            });
            tableItems.Add(new TableItem()
            {
                Heading = "New Delhi",
                SubHeading = "India",
                ImageResourceId = Resource.Drawable.img_india
                                                ,
                Description = "India is a vast South Asian country with diverse terrain " +
                                                                "– from Himalayan peaks to Indian Ocean coastline – " +
                                                                "and history reaching back 5 millennia. " +
                                                                "In the north, Mughal Empire landmarks include Delhi’s Red Fort complex " +
                                                                "and massive Jama Masjid mosque, plus Agra’s iconic Taj Mahal mausoleum. " +
                                                                "Pilgrims bathe in the Ganges in Varanasi," +
                                                                " and Rishikesh is a yoga centre and base for Himalayan trekking."
            });
            tableItems.Add(new TableItem()
            {
                Heading = "Mexico City",
                SubHeading = "Mexico",
                ImageResourceId = Resource.Drawable.img_mexico
                                               ,
                Description = "Mexico is a country between the U.S. and Central America that's known for its Pacific " +
                                                                "and Gulf of Mexico beaches and its diverse landscape of mountains, deserts and jungles. " +
                                                                "Ancient ruins such as Teotihuacán and the Mayan city of Chichén Itzá are scattered throughout the country, " +
                                                                "as are Spanish colonial-era towns. In capital Mexico City, upscale shops" +
                                                                ", renowned museums and gourmet restaurants cater to modern life."
            });
            tableItems.Add(new TableItem()
            {
                Heading = "Moscow",
                SubHeading = "Russia",
                ImageResourceId = Resource.Drawable.img_russia
                                              ,
                Description = "Russia, the world’s largest nation, borders European and Asian countries" +
                                                                " as well as the Pacific and Arctic oceans. Its landscape ranges from tundra " +
                                                                "and forests to subtropical beaches. It’s famous for Moscow's Bolshoi " +
                                                                "and St. Petersburg's Mariinsky ballet companies. St. Petersburg, " +
                                                                "founded by Russian leader Peter the Great, has the baroque Winter Palace, " +
                                                                "now housing part of the State Hermitage Museum’s art collection."
            });
            tableItems.Add(new TableItem()
            {
                Heading = "Taipei",
                SubHeading = "Taiwan",
                ImageResourceId = Resource.Drawable.img_taiwan
                                                ,
                Description = "Taiwan is a small island nation 180km east of China with modern cities," +
                                                                " traditional Chinese temples, hot springs resorts and dramatic mountainous terrain. " +
                                                                "Taipei, the country’s capital in the north, is known for its busy night markets, " +
                                                                "Chinese Imperial art at the National Palace Museum and Taipei 101, a 509m-tall, " +
                                                                "bamboo-shaped skyscraper with an observation deck."
            });

        }
    }
}
