using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adventureGame
{
    public partial class Form1 : Form
    {
        //set to correct beginnign page
        int page = 1;
        //soundplayer set up
        SoundPlayer footteps = new SoundPlayer(Properties.Resources.footsteps);
        SoundPlayer greeting = new SoundPlayer(Properties.Resources.creepyGreeting);
        SoundPlayer dead = new SoundPlayer(Properties.Resources.youDead);
        SoundPlayer freezer = new SoundPlayer(Properties.Resources.freezerIcecream);
        SoundPlayer boo = new SoundPlayer(Properties.Resources._563844__disarmenemyships__boo);
        SoundPlayer music = new SoundPlayer(Properties.Resources.playAgain);
        
        public Form1()
        {
            //set up beginning page
            InitializeComponent();
            imageLabel.Image = Properties.Resources.street;
            footteps.Play();
            textLabel.Text = "Youre walking down the street when you get hungry. What should you eat?";
            option1Button.Visible = true;
            option2Button.Visible = true;
            option1Button.Text = "icecream";
            option2Button.Text = "sushi";
            option3Button.Visible = false;
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //set page to go to correct page at button click
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 11;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 20;
            }
            else if (page == 18)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 1;
            }
            //switch statement to set up page info
            switch (page)
            {
                case 1:

                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "Youre walking down the street when you get hungry. What should you eat?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "icecream";
                    option2Button.Text = "sushi";
                    option3Button.Visible = false;



                    break;
                case 2:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    footteps.Play();
                    textLabel.Text = "You go into the icecream shop. Do you greet the owner?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "yes";
                    option2Button.Text = "no";
                    option3Button.Visible = false;

                    break;
                case 3:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    greeting.Play();
                    textLabel.Text = "The owner says hi back. Would you like icecream or cookie dough?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "icecream";
                    option2Button.Text = "cookie dough";
                    option3Button.Visible = false;


                    break;
                case 4:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    freezer.Play();
                    textLabel.Text = "you've picked icecream! would you like cotton candy, heavenly hash or cookies and cream?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "cotton candy";
                    option2Button.Text = "cookies and cream";
                    option3Button.Visible = true;
                    option3Button.Text = "heavenly hash";
                    break;
                case 5:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "A clown jumped out and killed you with an axe because cotton candy icecream is for children";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 6:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You got your icecream and begin to leave. Do you leave from the front or the back door?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "front";
                    option2Button.Text = "back";
                    option3Button.Visible = false;

                    break;
                case 7:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You continue walking down the street as your tounge begins to swell. Do you keep walking or go back to the iccream shop?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "keep walking";
                    option2Button.Text = "turn around";
                    option3Button.Visible = false;
                    break;
                case 8:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "you threatened to sue the icecream lady so she strangeled you and turned you into a new icecream flavour";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 9:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The icecream lady locks you in a room of melted heavenly hash and you drown to death";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 10:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "you fall into a bottomless pit and die";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 11:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "Your throat closed and you die of anaphylactic shock";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 12:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    freezer.Play();
                    textLabel.Text = "You asked for cookie dough. Would you like chocolate chip or birthday cake?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "chocolate chip";
                    option2Button.Text = "birthday cake";
                    option3Button.Visible = false;
                    break;
                case 13:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "there were razorblades in your cookie dough and you bled to death";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 14:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The icecream lady used her icecream scoop to scoop out your eyes. you bled to death in her walk in body freezer";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 15:
                    imageLabel.Image = Properties.Resources.sushiRestaurant;
                    footteps.Play();
                    textLabel.Text = "You go to the sushi place. Would you like regular california rolls or spicy california rolls?";
                    option1Button.Visible = true;
                    option1Button.Text = "regular";
                    option2Button.Text = "spicy";
                    option3Button.Visible = false;

                    break;
                case 16:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The sushi man wacked you ontop of the head with a dead fish and you died from blunt trauma";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 17:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You leave the sushi place. Do you go left or right?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "left";
                    option2Button.Text = "right";
                    option3Button.Visible = false;
                    break;
                case 18:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You find a homeless man looking for food. Do you give him your sushi?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "yes";
                    option2Button.Text = "no";
                    option3Button.Visible = false;
                    break;
                case 19:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The homeless man hates spicy food so he ran over ypu with his shopping cart and you died";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 20:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "you got jumped on the side if the road and died";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 21:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "the homeless man killed you and eats your dead body";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 22:
                    imageLabel.Image = Properties.Resources.final_image_screen;
                    music.Play();
                    textLabel.Text = "Thank you for playing!";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    Application.Exit();
                    break;

                case 23:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "your sushi was poisonous and you died";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 99:
                    imageLabel.Image = Properties.Resources.blood;
                    boo.Play();
                    textLabel.Text = "you lost";
                    Refresh();
                    Thread.Sleep(2000);
                    textLabel.Text += "\n Would you like to play again?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "yes";
                    option2Button.Text = "no";
                    option3Button.Visible = false;
                    break;
            }

        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //set page to go to correct page at button click
            if (page == 1)
            {
                page = 15;
            }
            else if (page == 2)
            {
                page = 14;
            }
            else if (page == 3)
            {
                page = 12;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 10;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 15)
            {
                Random randGen = new Random();
                int percent = randGen.Next(1, 11);
                if (percent < 5)
                { page = 17; }
                else
                { page = 99; }

            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 21;
            }
            else if (page == 99)
            {
                page = 22;
            }
            //switch statement to set up page info
            switch (page)
            {
                case 1:

                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "Youre walking down the street when you get hungry. What should you eat?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "icecream";
                    option2Button.Text = "sushi";
                    option3Button.Visible = false;



                    break;
                case 2:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    footteps.Play();
                    textLabel.Text = "You go into the icecream shop. Do you greet the owner?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "yes";
                    option2Button.Text = "no";
                    option3Button.Visible = false;

                    break;
                case 3:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    greeting.Play();
                    textLabel.Text = "The owner says hi back. Would you like icecream or cookie dough?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "icecream";
                    option2Button.Text = "cookie dough";
                    option3Button.Visible = false;


                    break;
                case 4:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    freezer.Play();
                    textLabel.Text = "you've picked icecream! would you like cotton candy, heavenly hash or cookies and cream?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "cotton candy";
                    option2Button.Text = "cookies and cream";
                    option3Button.Visible = true;
                    option3Button.Text = "heavenly hash";
                    break;
                case 5:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "A clown jumped out and killed you with an axe because cotton candy icecream is for children";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 6:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You got your icecream and begin to leave. Do you leave from the front or the back door?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "front";
                    option2Button.Text = "back";
                    option3Button.Visible = false;

                    break;
                case 7:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You continue walking down the street as your tounge begins to swell. Do you keep walking or go back to the iccream shop?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "keep walking";
                    option2Button.Text = "turn around";
                    option3Button.Visible = false;
                    break;
                case 8:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "you threatened to sue the icecream lady so she strangeled you and turned you into a new icecream flavour";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 9:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The icecream lady locks you in a room of melted heavenly hash and you drown to death";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 10:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "you fall into a bottomless pit and die";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 11:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "Your throat closed and you die of anaphylactic shock";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 12:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    freezer.Play();
                    textLabel.Text = "You asked for cookie dough. Would you like chocolate chip or birthday cake?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "chocolate chip";
                    option2Button.Text = "birthday cake";
                    option3Button.Visible = false;
                    break;
                case 13:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "there were razorblades in your cookie dough and you bled to death";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 14:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The icecream lady used her icecream scoop to scoop out your eyes. you bled to death in her walk in body freezer";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 15:
                    imageLabel.Image = Properties.Resources.sushiRestaurant;
                    footteps.Play();
                    textLabel.Text = "You go to the sushi place. Would you like regular california rolls or spicy california rolls?";
                    option1Button.Visible = true;
                    option1Button.Text = "regular";
                    option2Button.Text = "spicy";
                    option3Button.Visible = false;

                    break;
                case 16:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The sushi man wacked you ontop of the head with a dead fish and you died from blunt trauma";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 17:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You leave the sushi place. Do you go left or right?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "left";
                    option2Button.Text = "right";
                    option3Button.Visible = false;
                    break;
                case 18:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You find a homeless man looking for food. Do you give him your sushi?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "yes";
                    option2Button.Text = "no";
                    option3Button.Visible = false;
                    break;
                case 19:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The homeless man hates spicy food so he ran over ypu with his shopping cart and you died";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 20:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "you got jumped on the side if the road and died";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 21:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "the homeless man killed you and eats your dead body";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 22:
                    imageLabel.Image = Properties.Resources.final_image_screen;
                    music.Play();
                    textLabel.Text = "Thank you for playing!";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    Application.Exit();
                    break;

                case 23:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "your sushi was poisonous and you died";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 99:
                    imageLabel.Image = Properties.Resources.blood;
                    boo.Play();
                    textLabel.Text = "you lost";
                    Refresh();
                    Thread.Sleep(2000);
                    textLabel.Text += "\n Would you like to play again?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "yes";
                    option2Button.Text = "no";
                    option3Button.Visible = false;
                    break;
            }
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            //set page to take you to correct page based off button click
            if (page == 4)
            {
                page = 9;
            }
           
            //switch statement to set up page info
            switch (page)
            {
                case 1:

                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "Youre walking down the street when you get hungry. What should you eat?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "icecream";
                    option2Button.Text = "sushi";
                    option3Button.Visible = false;



                    break;
                case 2:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    footteps.Play();
                    textLabel.Text = "You go into the icecream shop. Do you greet the owner?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "yes";
                    option2Button.Text = "no";
                    option3Button.Visible = false;

                    break;
                case 3:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    greeting.Play();
                    textLabel.Text = "The owner says hi back. Would you like icecream or cookie dough?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "icecream";
                    option2Button.Text = "cookie dough";
                    option3Button.Visible = false;


                    break;
                case 4:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    freezer.Play();
                    textLabel.Text = "you've picked icecream! would you like cotton candy, heavenly hash or cookies and cream?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "cotton candy";
                    option2Button.Text = "cookies and cream";
                    option3Button.Visible = true;
                    option3Button.Text = "heavenly hash";
                    break;
                case 5:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "A clown jumped out and killed you with an axe because cotton candy icecream is for children";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 6:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You got your icecream and begin to leave. Do you leave from the front or the back door?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "front";
                    option2Button.Text = "back";
                    option3Button.Visible = false;

                    break;
                case 7:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You continue walking down the street as your tounge begins to swell. Do you keep walking or go back to the iccream shop?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "keep walking";
                    option2Button.Text = "turn around";
                    option3Button.Visible = false;
                    break;
                case 8:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "you threatened to sue the icecream lady so she strangeled you and turned you into a new icecream flavour";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 9:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The icecream lady locks you in a room of melted heavenly hash and you drown to death";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 10:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "you fall into a bottomless pit and die";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 11:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "Your throat closed and you die of anaphylactic shock";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 12:
                    imageLabel.Image = Properties.Resources.icecreamShop;
                    freezer.Play();
                    textLabel.Text = "You asked for cookie dough. Would you like chocolate chip or birthday cake?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "chocolate chip";
                    option2Button.Text = "birthday cake";
                    option3Button.Visible = false;
                    break;
                case 13:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "there were razorblades in your cookie dough and you bled to death";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 14:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The icecream lady used her icecream scoop to scoop out your eyes. you bled to death in her walk in body freezer";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 15:
                    imageLabel.Image = Properties.Resources.sushiRestaurant;
                    footteps.Play();
                    textLabel.Text = "You go to the sushi place. Would you like regular california rolls or spicy california rolls?";
                    option1Button.Visible = true;
                    option1Button.Text = "regular";
                    option2Button.Text = "spicy";
                    option3Button.Visible = false;

                    break;
                case 16:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The sushi man wacked you ontop of the head with a dead fish and you died from blunt trauma";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 17:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You leave the sushi place. Do you go left or right?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "left";
                    option2Button.Text = "right";
                    option3Button.Visible = false;
                    break;
                case 18:
                    imageLabel.Image = Properties.Resources.street;
                    footteps.Play();
                    textLabel.Text = "You find a homeless man looking for food. Do you give him your sushi?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "yes";
                    option2Button.Text = "no";
                    option3Button.Visible = false;
                    break;
                case 19:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "The homeless man hates spicy food so he ran over ypu with his shopping cart and you died";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 20:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "you got jumped on the side if the road and died";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 21:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "the homeless man killed you and eats your dead body";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 22:
                    imageLabel.Image = Properties.Resources.final_image_screen;
                    music.Play();
                    textLabel.Text = "Thank you for playing!";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    Refresh();
                    Thread.Sleep(4000);
                    Application.Exit();
                    break;

                case 23:
                    imageLabel.Image = Properties.Resources.blood;
                    dead.Play();
                    textLabel.Text = "your sushi was poisonous and you died";
                    option1Button.Visible = true;
                    option1Button.Text = "continue";
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 99:
                    imageLabel.Image = Properties.Resources.blood;
                    boo.Play();
                    textLabel.Text = "you lost";
                    Refresh();
                    Thread.Sleep(2000);
                    textLabel.Text += "\n Would you like to play again?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Button.Text = "yes";
                    option2Button.Text = "no";
                    option3Button.Visible = false;
                    break;
            }
            //page = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
