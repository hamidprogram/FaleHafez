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

namespace FaleHafez
{
    class FalHa
    {
        public List<fal> FalList { get; set; }


        public FalHa()
        {
            FalList = new List<fal>();

            #region Fal 01
            StringBuilder sbfal1 = new StringBuilder();
            sbfal1.AppendLine("اگر روم ز پی اش فتنه‌ها برانگیزد");
            sbfal1.AppendLine("ور از طلب بنشینم به کینه برخیزد");
            sbfal1.AppendLine("و گر به رهگذری یک دم از وفاداری");
            sbfal1.AppendLine("چو گرد در پی اش افتم چو باد بگریزد");
            sbfal1.AppendLine("و گر کنم طلب نیم بوسه صد افسوس");
            sbfal1.AppendLine("ز حقه دهنش چون شکر فروریزد");
            sbfal1.AppendLine("من آن فریب که در نرگس تو می‌بینم");
            sbfal1.AppendLine("بس آب روی که با خاک ره برآمیزد");
            sbfal1.AppendLine("فراز و شیب بیابان عشق دام بلاست");
            sbfal1.AppendLine("کجاست شیردلی کز بلا نپرهیزد");
            sbfal1.AppendLine("تو عمر خواه و صبوری که چرخ شعبده باز");
            sbfal1.AppendLine("هزار بازی از این طرفه‌تر برانگیزد");
            sbfal1.AppendLine("بر آستانه تسلیم سر بنه حافظ");
            sbfal1.AppendLine("که گر ستیزه کنی روزگار بستیزد");

            FalList.Add(new fal()
            {
                FalID=1,
                FalSher=sbfal1.ToString(),
                FalTabir = "همیشه همه ی کارها بر وفق مراد نیست. خیلی هم تلاش نکن و آنچه برایت مقدر ضده به تو می رسد بی خود خود را به زمین و زمان نزن. کمی تامل کن. صبر داشته باش. دلت را قوی کن تا بتوانی فراز و نشیب زندگی را طی کنی. هر چند که زندگی تو را به بازی گرفته است. تسلیم خداوند باش نه دل خود"
            });
            #endregion


            #region Fal 02
            StringBuilder sbfal2 = new StringBuilder();

            sbfal2.AppendLine("عمر بگذشت به بی‌حاصلی و بوالهوسی");
            sbfal2.AppendLine("ای پسر جام می‌ام ده که به پیری برسی");
            sbfal2.AppendLine("چه شکرهاست در این شهر که قانع شده‌اند");
            sbfal2.AppendLine("شاهبازان طریقت به مقام مگسی");
            sbfal2.AppendLine("دوش در خیل غلامان درش می‌رفتم");
            sbfal2.AppendLine("گفت ای عاشق بیچاره تو باری چه کسی");
            sbfal2.AppendLine("با دل خون شده چون نافه خوشش باید بود");
            sbfal2.AppendLine("هر که مشهور جهان گشت به مشکین نفسی");
            sbfal2.AppendLine("لمع البرق من الطور و آنست به");
            sbfal2.AppendLine("فلعلی لک آت بشهاب قبس");
            sbfal2.AppendLine("کاروان رفت و تو در خواب و بیابان در پیش");
            sbfal2.AppendLine("وه که بس بی‌خبر از غلغل چندین جرسی");
            sbfal2.AppendLine("بال بگشا و صفیر از شجر طوبی زن");
            sbfal2.AppendLine("حیف باشد چو تو مرغی که اسیر قفسی");
            sbfal2.AppendLine("تا چو مجمر نفسی دامن جانان گیرم");
            sbfal2.AppendLine("جان نهادیم بر آتش ز پی خوش نفسی");
            sbfal2.AppendLine("چند پوید به هوای تو ز هر سو حافظ");
            sbfal2.AppendLine("یسر الله طریقا بک یا ملتمسی");

            FalList.Add(new fal()
            {
                FalID = 2,
                FalSher = sbfal2.ToString(),
                FalTabir = "در گذر عمر غافل مانده اید اگر می خواهید به قله های موفقیت صعود کنید از تجربه ی پیران استفاده کنید تا خودتان نیز مانند عمری طولانی و با عزت داشته باشید. خیلی زود گول ظاهر مردم را می خورید و خودتان را کوچک می شمارید. مقامتان بالا می رود و زبانزد خاص و عام می شوید."
            });
            #endregion


            #region Fal 03
            StringBuilder sbfal3 = new StringBuilder();

            sbfal3.AppendLine("صلاح از ما چه می‌جویی که مستان را صلا گفتیم");
            sbfal3.AppendLine("به دور نرگس مستت سلامت را دعا گفتیم");
            sbfal3.AppendLine("در میخانه‌ام بگشا که هیچ از خانقه نگشود");
            sbfal3.AppendLine("گرت باور بود ور نه سخن این بود و ما گفتیم");
            sbfal3.AppendLine("من از چشم تو ای ساقی خراب افتاده‌ام لیکن");
            sbfal3.AppendLine("بلایی کز حبیب آید هزارش مرحبا گفتیم");
            sbfal3.AppendLine("اگر بر من نبخشایی پشیمانی خوری آخر");
            sbfal3.AppendLine("به خاطر دار این معنی که در خدمت کجا گفتیم");
            sbfal3.AppendLine("قدت گفتم که شمشاد است بس خجلت به بار آورد");
            sbfal3.AppendLine("که این نسبت چرا کردیم و این بهتان چرا گفتیم");
            sbfal3.AppendLine("جگر چون نافه‌ام خون گشت کم زینم نمی‌باید");
            sbfal3.AppendLine("جزای آن که با زلفت سخن از چین خطا گفتیم");
            sbfal3.AppendLine("تو آتش گشتی ای حافظ ولی با یار درنگرفت");
          
   

            FalList.Add(new fal()
            {
                FalID = 3,
                FalSher = sbfal3.ToString(),
                FalTabir = "صلاح و مشورت بهترین راهنما برای آینده روشن تان می باشد. دعای سلامتی همیشه با شماست و از بلایا ایمن هستید. در همه حال انفاق و کرم کنید که این کار روشن کننده ی راهتان می اشد و از این کار پشیمان نخواهید شد. مواظب صحبت کردنتان هم باشید که از آن به ضرر خودتان استفاده می کنند. از لحظه لحظه ی زندگیتان استفاده کنید که وقت طلاست"
            });
            #endregion

            #region Fal 04
            StringBuilder sbfal4 = new StringBuilder();

            sbfal4.AppendLine("دیده دریا کنم و صبر به صحرا فکنم");
            sbfal4.AppendLine("و اندر این کار دل خویش به دریا فکنم");
            sbfal4.AppendLine("از دل تنگ گنهکار برآرم آهی");
            sbfal4.AppendLine("کآتش اندر گنه آدم و حوا فکنم");
            sbfal4.AppendLine("مایه خوشدلی آن جاست که دلدار آن جاست");
            sbfal4.AppendLine("می‌کنم جهد که خود را مگر آن جا فکنم");
            sbfal4.AppendLine("بگشا بند قبا ای مه خورشیدکلاه");
            sbfal4.AppendLine("تا چو زلفت سر سودازده در پا فکنم");
            sbfal4.AppendLine("خورده‌ام تیر فلک باده بده تا سرمست");
            sbfal4.AppendLine("عقده دربند کمر ترکش جوزا فکنم");
            sbfal4.AppendLine("جرعه جام بر این تخت روان افشانم");
            sbfal4.AppendLine("غلغل چنگ در این گنبد مینا فکنم");
            sbfal4.AppendLine("حافظا تکیه بر ایام چو سهو است و خطا");
            sbfal4.AppendLine("من چرا عشرت امروز به فردا فکنم");



            FalList.Add(new fal()
            {
                FalID = 4,
                FalSher = sbfal4.ToString(),
                FalTabir = "دل به دریا زده اید. برای جبران کارهای گذشته حاضرید هر اقدامی بکنید. زمانی وجدانتان راحت می شود که همه کارها را سر و سامان دهید. مشکلات زندگی باعث شده تا سرتان به سنگ بخورد. تصمیم بگیرید برای رسیدن به مقصود کاری کنید که همه انگشت به دهان بمانند. حالا دیگر خوب و بد را تشخیص می دهید."
            });
            #endregion


            #region Fal 05
            StringBuilder sbfal5 = new StringBuilder();

            sbfal5.AppendLine("دل و دینم شد و دلبر به ملامت برخاست");
            sbfal5.AppendLine("گفت با ما منشین کز تو سلامت برخاست");
            sbfal5.AppendLine("که شنیدی که در این بزم دمی خوش بنشست");
            sbfal5.AppendLine("که نه در آخر صحبت به ندامت برخاست");
            sbfal5.AppendLine("شمع اگر زان لب خندان به زبان لافی زد");
            sbfal5.AppendLine("پیش عشاق تو شب‌ها به غرامت برخاست");
            sbfal5.AppendLine("در چمن باد بهاری ز کنار گل و سرو");
            sbfal5.AppendLine("به هواداری آن عارض و قامت برخاست");
            sbfal5.AppendLine("مست بگذشتی و از خلوتیان ملکوت");
            sbfal5.AppendLine("به تماشای تو آشوب قیامت برخاست");
            sbfal5.AppendLine("پیش رفتار تو پا برنگرفت از خجلت");
            sbfal5.AppendLine("سرو سرکش که به ناز از قد و قامت برخاست");
            sbfal5.AppendLine("حافظ این خرقه بینداز مگر جان ببری");
            sbfal5.AppendLine("کاتش از خرقه سالوس و کرامت برخاست");





            FalList.Add(new fal()
            {
                FalID = 5,
                FalSher = sbfal5.ToString(),
                FalTabir = "ایمانت را قوی تر کن تا از رنج ملامت نجات یابی. گرفتاریت برطرف می شود. اگر در عین غمگینی خندیدی شاهکار کرده ای. کسانی که طرفداری تو را می کنند و از آشوب و غوغا نجاتت می دهند. تغییری در خود و افکارت بده. بدی ها را آتش بزن و بخشندگی را در خود پرورش بده."
            });
            #endregion
        }
    }


    public class fal
    {
        public int FalID { get; set; }

        public string FalSher { get; set; }

        public string FalTabir { get; set; }
    }

}