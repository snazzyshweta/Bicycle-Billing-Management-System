using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void View4_Activate(object sender, EventArgs e)
    {

        Label1.Text = TextBox1.Text;
        int day = Convert.ToInt32(TextBox2.Text);
        int month = Convert.ToInt32(TextBox3.Text);
        String description="";
        String zodiac="";
        if((day>=21 && month==3)||(day<20 && month==4)){
            zodiac = "Aries";
            description = "Aries is full of life and possesses high energy, which makes this sign always looking for a challenge. The typical Aries person is full of vitality, curiosity, and has a heightened sense of justice. They often excel at anything where a bit of competition is involved, whether this is of a cognitive nature or physical. The challenge is the thing. If there is a chance to win, to best someone, to show off abilities, Aries is in it to win it. The Aries person feels most alive when they are in control and leading others. They are often impatient and abrupt with those whom they feel are not their equals and are in a leadership position. Most Aries do not like being told what to do if the person in charge is less talented than they.";
            Image1.ImageUrl = "images/aries.jpg";
        }
        else if ((day >= 21 && month == 4) || (day <= 21 && month == 5)) {
            zodiac = "Taurus";
            description = "Tarus’s symbol is the bull because this sign’s characteristic is to be peaceful and methodical. This sign is often very deliberate in their actions, relaxed, and enjoys all of the sensual pleasures that abound in this dimension. Food, drink, sex, luxury, are all sought after by the typical taruean. Because this sign loves luxury they are willing to work hard to obtain it. They are slow to anger, but once disturbed it can be volatile. Taurus signs look for stability in their lives and in their partners and co-workers. Taurus people are not in a hurry, typically, and it can take them many years to decide what it is that they would like to do for a living, or where they’d like to go on vacation. Many of this sign prefer to live in the country as they are drawn to the earth and the natural world. Earth signs tend to have solid, reputable natures, which coincides with the Earth.";
            Image1.ImageUrl = "images/taurus.jpg";
        }
        else if ((day >= 22 && month == 5) || (day <= 21 && month == 6))
        {
            zodiac = "Gemini";
            description = "The Gemini symbol is that of a pair of twins. This is because this sign rarely likes to do anything alone. Gemini are never happier than when they are sharing ideas and concepts with someone else. Communication is a key element for this sign, so many of this sign go into occupations that include some communication in some large capacity. Curiosity is a key characteristic of this sign, and they are people persons. Gemini are great at parties because they can find almost anything to talk about with anyone. Gemini are adventurous by nature and so engage in traveling as often as they can as it affords them the opportunity to meet new people, experience new ideas, and to learn new concepts.";
            Image1.ImageUrl = "images/gemini.jpg";
        }
        else if ((day >= 22 && month == 6) || (day <= 22 && month == 7))
        {
            zodiac = "Cancer";
            description = "The crab symbolizes this sign for good reason. Just as the crab carries its own shell on its back, so too, does the typical cancerian…so to speak. The typical cancer person is all about home and family and is very dedicated and loyal to friends and family. Crabs often move sideways instead of moving in a straight line, and so will the person of this sign. Often, if it will avoid a fight, or achieve the goal, then moving in alternative directions to arrive at the destination is typical. They tend to grasp and hold tightly those things that make them happy, and never let go. The key characteristic of this sign is that Cancer people need to be needed. They need to know that they matter to someone and that they are secure in that love. Brave, courageous, protective, all describe the best possible traits of this sign. Shy, reserved, brooding, and moody, do not serve the cancer person well, but may surface if their needs are not being met";
            Image1.ImageUrl = "images/cancer.jpg";
        }
        else if ((day >= 23 && month == 7) || (day <= 22 && month == 8))
        {
            zodiac = "Leo";
            description = "Leo signs tend to like relaxation, preferably someplace warm and comfortable. Leo likes the big picture, not the small details and fine print. Things that are too complicated, involved, or boring, they have no patience for. They are natural leaders and don’t often do well in situations where they have to take orders from others.";
            Image1.ImageUrl = "images/leo.jpg";
        }
        else if ((day >= 23 && month == 8) || (day <= 22 && month == 9))
        {
            zodiac = "Virgo";
            description = "The cool, calm, clarity that this sign exudes is why the symbol of the Maiden was chosen. Virgo people are mild mannered on the surface, but underneath there is a flurry of activity. Their minds are never quiet; always thinking, calculating, assessing. They loves making something out of nothing, nurturing and growing small things. They tend to be extremely detail oriented and particularly like producing something that is not only useful, but beautiful and skillful.";
            Image1.ImageUrl = "images/virgo.jpg";
        }
        else if ((day >= 23 && month == 9) || (day <= 23 && month == 10))
        {
            zodiac = "Libra";
            description = "Libra people tend to need balance in their lives like no other sign of the zodiac, which makes the symbol of the scales particularly appropriate for this sign. Libra people need to keep a balance between work lives and recreational lives and an equal balance in their emotional and spiritual/physical lives. Because of this need Libra signs can sometimes seem wishy-washy when they are asked to make a decision. This is because they must ‘weigh’ all of their options. However, rest assured, that when a Libra makes up their mind the decision is likely to be the best win/win for all involved; benefiting the most people. This sign does not like to see people unhappy.";
            Image1.ImageUrl = "images/libra.jpg";
        }
        else if ((day >= 24 && month == 10) || (day <= 21 && month == 11))
        {
            zodiac = "Scorpio";
            description = "The symbol for Scorpio is the scorpion. This creature was chosen because it typifies many of the characteristics of this sign. The scorpio person is not necessarily aggressive on its own, unless provoked and in general would rather be contemplative. They crave alone time and often become extremely annoyed when they don’t get it. Scorpio people are great secret keepers and feel each emotion more intensely than other signs. Perhaps because of this they are able to be quite discerning when assisting people with their problems. They are able to cut to the bottom line and show others the best and the worst in their lives.";
            Image1.ImageUrl = "images/scorpio.jpg";
        }
        else if ((day >= 22 && month == 11) || (day <= 21 && month == 12))
        {
            zodiac = "Sagittarius";
            description = "Sagittarians crave the freedom of the open road, both metaphorically and physically. They are most unhappy when they are tied to a normal routine and can become restless in situations where there is not enough variety involved. Because they travel so much and are eager to experience new things, those of this sign are fun to be around and often have large numbers of friends. They question everything and think that everyone should do the same.";
            Image1.ImageUrl = "images/sagittarius.jpg";
        }
        else if ((day >= 22 && month == 12) || (day <= 21 && month == 1))
        {
            zodiac = "Capricorn";
            description = "Achievement is everything to a Capricorn. For this reason they tend to take life very seriously and are not tolerant of those who do not. They are also very good at state’s craft engaging in mental parrying at a high level. They are natural born leaders, politicians, mathematicians, and diplomats. Capricorn people tend to guard their hearts closely and well. To get close to a Capricorn may take some time, but once achieved, well worth it.";
            Image1.ImageUrl = "images/capricorn.jpg";
        }
        else if ((day >= 22 && month == 1) || (day <= 18 && month == 2))
        {
            zodiac = "Aquarius";
            description = "Fascinated by all things gadget, many Aquarians enjoy tinkering with inventions and processes. On the surface, Aquarius people are often not very emotional, because they are more concerned with the exchanging of ideas and how they might better assist someone in their cause. Aquarians have a great deal of patience and tolerance for their fellow man. They make excellent teachers and relief aid workers, though do not become personally involved with them.";
            Image1.ImageUrl = "images/aquarius.jpg";
        }
        else if ((day >= 19 && month == 2) || (day <= 20 && month == 3))
        {
            zodiac = "Pisces";
            description = "They are tremendously dedicated individuals, staying with companies for decades where others move from one job to the next. So, too, with relationships. Others may find Pisces difficult to get to know because they don’t often readily share their underlying passion and compassion. Pisces signs tend to be highly and deeply religious, and sometimes will go overboard with their devotion to their particular faith. This can also lead to intolerance and bigotry.";
            Image1.ImageUrl = "images/pisces.jpg";
        }

        Label3.Text = TextBox2.Text;
        Label4.Text = TextBox3.Text;
        Label2.Text = zodiac;
        Label5.Text = description;


       


    }
    protected void Button3_Click(object sender, EventArgs e)
    {
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {

    }
}