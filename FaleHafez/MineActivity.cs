using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Graphics;
using Android.Media;

namespace FaleHafez
{
    [Activity(Label = "فال حافظ")]
    public class MineActivity : Activity
    {
        ScrollView ScrFal;
        ScrollView ScrTabir;
        TextView LblFal;
        TextView LblTabir;
        int FalSize;
        int TabirSize;
        ImageButton BtnZoomOut;
        ImageButton BtnZoomIn;
        ImageButton BtnFal;
        ImageButton BtnPlay;
        int FalID;
        MediaPlayer _Player;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MineLayout);
            ScrFal = FindViewById<ScrollView>(Resource.Id.ScrFal);
            ScrTabir = FindViewById<ScrollView>(Resource.Id.ScrTabir);
            LblFal = FindViewById<TextView>(Resource.Id.LblFal);
            LblTabir = FindViewById<TextView>(Resource.Id.LblTabir);
            BtnFal = FindViewById<ImageButton>(Resource.Id.BtnFal);
            BtnZoomIn = FindViewById<ImageButton>(Resource.Id.BtnZoomIn);
            BtnZoomOut = FindViewById<ImageButton>(Resource.Id.BtnZoomOut);
            BtnPlay = FindViewById<ImageButton>(Resource.Id.BtnPlay);
            SetColorForScr();
            SetTextSize();
            BtnZoomIn.Click += BtnZoomIn_Click;
            BtnZoomOut.Click += BtnZoomOut_Click;
            BtnFal.Click += BtnFal_Click;
            BtnPlay.Click += BtnPlay_Click;

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if(FalID != 0)
            {
                if(_Player == null)
                {
                    switch (FalID)
                    {
                        case 1:
                            {
                                _Player = MediaPlayer.Create(this, Resource.Raw.Fal1);
                                break;
                            }
                        case 2:
                            {
                                _Player = MediaPlayer.Create(this, Resource.Raw.Fal2);
                                break;
                            }
                        case 3:
                            {
                                _Player = MediaPlayer.Create(this, Resource.Raw.Fal3);
                                break;
                            }
                        case 4:
                            {
                                _Player = MediaPlayer.Create(this, Resource.Raw.Fal4);
                                break;
                            }
                        case 5:
                            {
                                _Player = MediaPlayer.Create(this, Resource.Raw.Fal5);
                                break;
                            }
                    }
                    _Player.Start();
                    BtnPlay.SetBackgroundResource(Resource.Drawable.Stop);
                }
                else
                {
                    BtnPlay.SetBackgroundResource(Resource.Drawable.Play);
                    _Player.Stop();
                    _Player = null;
                }
            }
        }

        private void BtnFal_Click(object sender, EventArgs e)
        {
            if(_Player != null)
            {
                BtnPlay.SetBackgroundResource(Resource.Drawable.Play);
                _Player.Stop();
                _Player = null;
            }
            FalHa falha = new FalHa();
            int random = new Random().Next(0, falha.FalList.Count - 1);
            fal fall = falha.FalList[random];
            LblTabir.Text = fall.FalTabir;
            LblFal.Text = fall.FalSher;
            FalID = fall.FalID;

        }

        private void BtnZoomOut_Click(object sender, EventArgs e)
        {
            FalSize--;
            TabirSize--;
            SetTextSize();
        }

        private void BtnZoomIn_Click(object sender, EventArgs e)
        {
            FalSize++;
            TabirSize++;
            SetTextSize();
        }

        void SetColorForScr()
        {
            Color color = new Color(255, 255, 255, 170);
            ScrFal.SetBackgroundColor(color);
            ScrTabir.SetBackgroundColor(color);
        }
        void SetTextSize()
        {
            LblFal.SetTextSize(Android.Util.ComplexUnitType.Dip, FalSize);
            LblTabir.SetTextSize(Android.Util.ComplexUnitType.Dip, TabirSize);
        }
        protected override void OnDestroy()
        {
            if (_Player != null)
            {
                BtnPlay.SetBackgroundResource(Resource.Drawable.Play);
                _Player.Stop();
                _Player = null;
            }
            base.OnDestroy();
        }
    }
}