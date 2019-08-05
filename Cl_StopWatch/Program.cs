using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl_StopWatch
{
    class Program
    {
        public static void Listen(ConsoleKey key)
        {
            do
            {
                while (!Console.KeyAvailable)
                    continue;
            } while (Console.ReadKey(true).Key != key);
        }
        //B=66, E=69
        static void Main(string[] args)
        {
            Console.WriteLine(@"Stopwatch usage:
              press B - to start
              press E or Esc - to stop
              You cannot start stopwatch 2nd time after it have already started and cannot stop if it hasn't started yet.");

            do
            {
                while (!Console.KeyAvailable)
                    continue;
            } while (Console.ReadKey(true).Key != ConsoleKey.B);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Stopwatch started! Press <E> or <Esc> to stop.");

            while (!Console.KeyAvailable)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.B)
                {
                    stopwatch.Stop();
                    throw new InvalidOperationException("Stopwatch has already started! Exitinig...");
                }
                if (Console.ReadKey(true).Key == ConsoleKey.E)
                {
                    stopwatch.Stop();
                    TimeSpan result = stopwatch.end - stopwatch.begin;
                    Console.WriteLine("Duration: {0:d2} : {1:d2} : {2:d2}", result.Hours, result.Minutes, result.Seconds);
                    break;
                }
                continue; // good good :D working! :D ti kushay kushay))baaajiba^^ (: dedin kushay, men de kushayladim, neticesi bele oldu) nece bele? nushi mushi bele)) cixaq bala bala?
                //xee mne elimi yuyum elyim hazir olarsan o vaxta?xee
            }

            
            /*Stopwatch stopWatch = new Stopwatch();

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                stopWatch.Start();
                Console.WriteLine("stopwatch starts at: {0}", stopWatch.begin);
                Listen(ConsoleKey.E); // vrode usyo sekundu zvonok test it
                stopWatch.Stop();
                Console.WriteLine("stopwatch stopped at: {0}", stopWatch.end);
                TimeSpan result = stopWatch.end - stopWatch.begin;
                Console.WriteLine("Duration: {0:d2} : {1:d2} : {2:d2}", result.Hours, result.Minutes, result.Seconds);
            }
            */
            //eto yasno chto srabotayet, basha dushdum. demeli men de sehv basa dusmusdum dunen.
            // console.key consoleKey tipinde bir sey qaytarir int yox. indi basa dusdun tam?) vrode xeaydin olmayan ne qaldi ki "vrode" ?
            //dunende aydin idi amma sonra yadin olmadi yeni))) ona gore okay))) mene gore qullugun?sagligin))baziba:) okay. cixim?
            //eshe one question :D tolko ne pishi srazu kod :D smotri, esli peredat b - start olur, e - stop. uje net nujdi proveryat ego? neyi ? ne vaxt ?
            // vot tut yeni b-dirsa bashlasin, e-dirsa end elesin. bele ele de sen. console acilanda bashlamasin ozu. adam B bassa baslasin. b basmayana qeder hec ne 
            // bash vermesin. B basandan sonra baslasin stopw. daha sonra E bassa dayansin. sora da print elesin muddeti
            //nuu da ya tak i doljna sdelat. plyus ogranichit elemeliyem ki, b basilibsa ikinci defe birde b basmag olmaz poka end olmayib o birinci start. <-- bunun ucun
            // asagidaki kimi eliyenden sonra,  ancaq stopwatch baslayandan sonra tolko E basa bilecek user ) B basa bilmeyecek) specific bir sey elemeli deyilsen)))
            // zboy vermisen? :D deyesen biraz he :/ gel bele edek. 


            /**
             * 1) Console acilan kimi ekranda bunu yaz: 
             * Stopwatch usage:
             *   press B - to start
             *   press E or Esc - to stop
             * You cannot start stopwatch 2nd time after it have already started and cannot stop if it hasn't started yet.
             * 
             * 2) TOLKO <B> knopkasinin klick olub olmamasini yoxla, klick oldusa, start ele
             * 3) TOLKO <E> yada <Esc> knopkasinin klick olub olmamasini yoxla, klick oldusa, stop ele
             * 4) Console.WriteLine("Duration: {0:d2} : {1:d2} : {2:d2}", result.Hours, result.Minutes, result.Seconds);
             * 5) SEHRLI STEP: test it :D :D :D
             * 
             * Vessalam. sen bunu ele, basa duseceksen menim niye bele dediyimi. gozleyirem seni, yaz
             * 
             * ordasan??xeee chitayu chitayu... ne aydin deyil? denen izax edim) ok, shas popitayus sdelat. ti idi kushat, uje vremya
             * 20deq islemis gedecem. ruchnoylugum tutub-___-
             * 
             * step1 ele
             * Naila aya? step1 ele
             * men step1-de stopwatchi start ele yazmamisam deyesen hmm?)
             * 
             * step2-ni ele. bilirsen nece etmek lazimdi. ordasan Naila?dada burdayam. if(listen(b)) onda start elesin? yox
             * 2.1) B basilib basilmadigini yoxlayan kod yaz <-- ancaq bunu ele B basilibsa proqram finish olsun. Press any key blabla sozleri gelsin
             * listen(b)? bilmirem ozun fikirles. her sey var elinde) butun kubikleri yazmisan, varindi. yig hamsin bir yere davay davay fikirlesme, yaz bilirsen her seyi. 
             * mellim deyilem e men unide :D senin qiymetini kesim :D yada danlayim seni)) sehv yazassan deyecem ki sehvdi. duzeldesssen. yada men duzeldecem ;) :) 
             * davay lovely) sekundu, Pavel :D men yemeyimi qizdirim gellem. coreyi gelib goturrem senden -->
             * 2.2) stopwatch start ele indi )
             * 3-u ele
             * 4-u ele)
             * eee :D ti izdevayeshsyaa :D bunu elemishdimde prosto bayag srazu bashdiyirdi start, stop elemey olurdu E basanda. a potom lyuboy knoproy eshe raz start
             * olurdu. mne je ne eto nujno bilo :/ ??dyan, ya ne pomnyu demishdim sene ya yox. minutku
             * ya tam v stope eto xotela sdelat, no ne znayu on shas pravilniy ili net. chashdim :D koroche, poyesh potom pogovorim))
             */






            /**
             console acilanda bashlamasin ozu. adam B bassa baslasin. b basmayana qeder hec ne 
            // bash vermesin. B basandan sonra baslasin stopw. daha sonra E bassa dayansin. sora da print elesin muddeti
             */


            /**
             * 1. ilk once loop ile inputun olub olmadigini yoxla
             * 2. input yoxdursa, start() ele, ya nem bashqa bir shey ele
             * 3. daha sonra infinite loop-a gir, hansi ki basilan knopkanin 
             *    B olub olmadigini yoxlayir
             * 
             * Aydin olmayan ne var?bele basha dushurem. ne basa dusmusense kod kimi yaz bura.
             * ne basa dusmusense yaz. utanma, qorxma, cekinme. production mehsulu deyil yazdigin kod
             * oyrenmeyincundu. nece basa dusdunse dediyimi yaz o formada. problemde ele burasindadida 
             * harasinda? hmm?
             * 
             * inputun olub olmadigini nece yoxlayirsan? kod konu yoxlamiram, yeni elememishem. 
             * 
             * Console.KeyAvailable --- bu birinci kubik
             * 
             * bu kubiki infinite loop ichine atsan, 2ci kubiki ozun etmis olacaqsan)
             * 
             * znachit, 2 kubik hazir. right? :) 
             * xe. sen hansisa knopkaya basdin duzdu? he. indi bax nece teyin edersen ki, hansi knopkaya basilib, ve
             * o ANCAQ VE ANCAQ hemin o xususi knopkaya basilana qeder print elesin? oxumamisdin? :Doxumushdum e, amma 
             * yazmamish nece deyim? 
             * 
             * kodu yazmamishdan once skaji mana) chto skzat sene?))) yeni kodu yazmamisdan qabaq soz ile denen :D 
             * alo?aya hec. poka console.readkey(true).key ne budet ravno filan herf yes yes it is! indi kodunu yaz
             * ya tut tut :D ok))
             */

            // yaz bura kodu. ne yadindan cixdi? indi oxuyacam bayagkini vspomnyu issense mahnini sondur. net ne meshayet
            //do
            //{
            //    while (!Console.KeyAvailable)
            //        continue;
            //} while (Console.ReadKey(true).Key != ConsoleKey.A);
            // test it ;) podojdi)))onsuzda naushnikda deyildim)) think. total 3 setir kod yazmalisan. 
            // o 3 setirden bir denesi } isharesidi. diger 2sidi esas logic. fikirles. issen gel bzm otaga. 
            // hec kes netu.hamisi gedib
            // men knopkaya basdim deye dayandi. indi bir de ozun luboy knopkaya bas. okay? ok


            //TimeSpan result = stopWatch.end - stopWatch.begin;
            //Console.WriteLine("Duration: {0}", result);

            // vrode rabotayet. vrode ???!!!? :D nuu rabotayet )))

            //ya etot continue znayesh skolko iskala -____________- :D indi oz kodlarini yaz. esas business logici yaz
            //podojdi ya na bumajke yemeye neyin var? :/ 1 dene balaca alma)) xochesh? wokoladi basib yedin? :D xee, ti je ne zaxotel. yaxsi)) men gedim bir sey alim gellem
            // ese issen? yox, prosto tormoju ge bura senin pasini achim:DDDDeee:D ne eeee? :D gelmirsense gedey eve. gelirsense gel :D :D gelim chixag)) yaxsi)) zakrivayu ok




        }
    }
}
