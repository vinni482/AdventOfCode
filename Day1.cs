﻿namespace AdventOfCode
{
    internal class Day1
    {
        public readonly string input;
        public readonly List<int> left;
        public readonly List<int> right;

        public Day1()
        {
            input =  "80414   72092\r\n17250   26414\r\n23063   14603\r\n89663   35210\r\n27237   81657\r\n81505   58579\r\n67427   21819\r\n95906   51098\r\n19112   81697\r\n92811   11615\r\n13558   69095\r\n88090   73934\r\n78043   93679\r\n97013   51098\r\n61919   70291\r\n72566   95692\r\n35301   95381\r\n74588   63879\r\n85685   96855\r\n16993   51098\r\n76769   17580\r\n77423   89200\r\n71971   73934\r\n58114   82963\r\n53172   86048\r\n88833   51731\r\n77532   77433\r\n64134   46227\r\n76211   54394\r\n53521   98072\r\n33006   81657\r\n78562   93679\r\n71763   23743\r\n33704   37560\r\n72748   68417\r\n52182   40490\r\n58871   19269\r\n86416   22807\r\n92658   54533\r\n53632   63601\r\n65521   11026\r\n39351   14603\r\n53327   96729\r\n71673   28822\r\n79947   80534\r\n34434   42913\r\n72493   90961\r\n70108   50527\r\n75643   20937\r\n32893   51023\r\n95833   76926\r\n36562   49768\r\n93015   93096\r\n26814   81697\r\n47888   60992\r\n20711   51603\r\n30854   97280\r\n84916   51995\r\n87347   52804\r\n57354   11615\r\n27380   79353\r\n66813   15062\r\n26583   19269\r\n11010   80969\r\n49768   11026\r\n75348   40254\r\n51341   90357\r\n88498   51995\r\n87012   80829\r\n38931   46572\r\n60255   57830\r\n26660   90149\r\n22304   77433\r\n50828   16902\r\n58198   93679\r\n80389   57866\r\n95968   21832\r\n13821   58185\r\n54447   81657\r\n51614   45763\r\n21626   27821\r\n51912   65273\r\n67163   14099\r\n68836   80969\r\n93741   57830\r\n19766   18499\r\n53097   19238\r\n52636   49690\r\n96518   44386\r\n43414   40323\r\n42478   78230\r\n83274   61463\r\n10577   37309\r\n96150   57830\r\n61460   79316\r\n52954   35440\r\n86111   85469\r\n67981   85690\r\n89005   81697\r\n25240   21563\r\n52033   21832\r\n57669   45491\r\n91455   22543\r\n46929   80153\r\n46377   27335\r\n60937   81369\r\n51158   10062\r\n99819   77433\r\n98623   31360\r\n58882   43968\r\n51995   14603\r\n11409   35440\r\n81603   16993\r\n66492   77433\r\n57941   37767\r\n87499   44307\r\n24055   85469\r\n62911   81697\r\n88178   93096\r\n86394   81657\r\n90516   14780\r\n85871   68621\r\n81993   43091\r\n51752   19735\r\n69157   16533\r\n61057   76566\r\n11966   43965\r\n69037   13213\r\n13959   14603\r\n65457   73934\r\n59043   11823\r\n59012   49282\r\n77433   12025\r\n50535   69308\r\n44606   63296\r\n27732   11026\r\n57613   38704\r\n23581   38961\r\n77790   82219\r\n76064   35440\r\n82156   37240\r\n35773   82219\r\n62564   11615\r\n90910   68175\r\n20592   62481\r\n98817   93643\r\n21496   95618\r\n70730   93679\r\n42732   35096\r\n12004   51995\r\n60678   61719\r\n21736   75391\r\n49338   82219\r\n94653   97525\r\n15975   93679\r\n30819   47988\r\n32018   82262\r\n98072   76683\r\n48854   14603\r\n86331   58697\r\n27964   11615\r\n91279   85469\r\n85866   62179\r\n30965   15062\r\n73817   40254\r\n61151   35757\r\n65955   80212\r\n43518   14772\r\n74507   45177\r\n78231   28454\r\n58577   64754\r\n50935   96099\r\n20406   42556\r\n65588   39264\r\n83709   92854\r\n93861   87149\r\n89686   29388\r\n49549   21832\r\n77705   21931\r\n73934   97128\r\n11856   50527\r\n42543   97307\r\n43899   73636\r\n11382   44101\r\n80304   81697\r\n78437   21832\r\n67304   99462\r\n14681   20982\r\n26328   73934\r\n28487   28822\r\n20176   64754\r\n36609   84018\r\n87540   51731\r\n24635   49254\r\n24281   35329\r\n79705   21309\r\n76132   54958\r\n37203   61911\r\n92472   14603\r\n44296   51731\r\n88466   14613\r\n88696   56350\r\n99883   71141\r\n68400   51995\r\n43628   23867\r\n16328   36219\r\n27544   64508\r\n70297   21832\r\n20741   64754\r\n11270   73934\r\n10412   91984\r\n91908   77433\r\n38346   56835\r\n31561   97432\r\n94818   28401\r\n66556   51158\r\n98386   19269\r\n22468   90492\r\n39877   56803\r\n32210   90889\r\n36384   36321\r\n33040   23463\r\n26433   50527\r\n88796   99445\r\n89851   98072\r\n57361   96155\r\n93159   98072\r\n57209   24350\r\n74864   16993\r\n75359   51158\r\n85735   80267\r\n92049   40490\r\n38526   82756\r\n29762   10076\r\n22315   97525\r\n59011   37750\r\n47720   93096\r\n81338   35440\r\n99137   28822\r\n99776   31007\r\n66809   57830\r\n92149   53891\r\n82219   40693\r\n70143   25748\r\n11615   51731\r\n58427   31738\r\n57505   78654\r\n86145   24587\r\n50910   14603\r\n79644   54957\r\n53087   21832\r\n54363   16993\r\n42928   19269\r\n45354   33015\r\n78928   16533\r\n84457   77433\r\n16922   55466\r\n83190   68611\r\n66996   37945\r\n44607   74216\r\n25805   98578\r\n41285   15062\r\n48576   70411\r\n89495   16533\r\n86342   43664\r\n82170   57830\r\n97793   22785\r\n76814   51995\r\n80484   37096\r\n97336   28303\r\n43010   51158\r\n70744   52252\r\n47477   51731\r\n36072   94764\r\n13423   51002\r\n44978   65677\r\n23730   51384\r\n93679   21832\r\n90587   59127\r\n90250   90452\r\n27489   51731\r\n43850   50527\r\n74656   80969\r\n69311   17704\r\n43315   16533\r\n25345   22687\r\n66317   51731\r\n15645   69119\r\n47505   92406\r\n97390   49768\r\n40510   19269\r\n80347   34848\r\n82515   28822\r\n24628   56489\r\n73049   62481\r\n26616   11026\r\n96198   40254\r\n53185   64580\r\n43235   74362\r\n33359   93315\r\n70878   26005\r\n83010   51098\r\n45114   95350\r\n67086   35440\r\n57393   40583\r\n22687   61082\r\n90550   44094\r\n97845   28945\r\n21978   85054\r\n79527   71562\r\n44362   66635\r\n76250   98072\r\n33066   32780\r\n49932   73934\r\n45251   92545\r\n99445   13368\r\n93909   90723\r\n55599   85469\r\n51525   49768\r\n50390   74131\r\n11040   11026\r\n10881   24387\r\n50998   85469\r\n24196   45910\r\n18240   74337\r\n50033   80969\r\n91104   35077\r\n98342   15002\r\n85971   80969\r\n54974   78550\r\n81514   11026\r\n88986   33449\r\n77486   77130\r\n87829   20341\r\n67680   85469\r\n54909   11615\r\n91875   55985\r\n57467   71806\r\n58009   52471\r\n19775   45594\r\n68655   85646\r\n72404   80969\r\n41867   22896\r\n12808   41935\r\n94055   78793\r\n35440   99605\r\n99161   93096\r\n34755   29742\r\n15454   46732\r\n90823   94570\r\n38962   18692\r\n29616   49757\r\n22901   64168\r\n83528   81657\r\n85305   28094\r\n69789   39579\r\n90772   78280\r\n25745   46666\r\n14697   20975\r\n53375   89423\r\n99639   49768\r\n37929   85469\r\n49322   28822\r\n93096   42651\r\n90967   22687\r\n94334   12698\r\n73258   52012\r\n99816   50527\r\n27154   60418\r\n20937   95134\r\n45082   73934\r\n89681   42101\r\n76459   85469\r\n64754   81657\r\n86033   90176\r\n44242   51731\r\n13021   64971\r\n63412   51731\r\n21580   43974\r\n41194   62481\r\n44532   58882\r\n88636   99057\r\n52380   26629\r\n61255   17603\r\n63728   14603\r\n59299   40254\r\n65394   17790\r\n45524   64610\r\n66346   48648\r\n24397   44892\r\n25681   22437\r\n16533   85469\r\n13083   47222\r\n25911   82219\r\n84214   81657\r\n72049   20603\r\n91145   29744\r\n90207   82274\r\n22512   92421\r\n80671   14603\r\n17644   98072\r\n55263   30672\r\n40433   43484\r\n57084   63914\r\n85469   93679\r\n46044   60813\r\n83475   70576\r\n96868   38714\r\n30799   98072\r\n69140   92270\r\n84171   80867\r\n14011   41743\r\n59689   21832\r\n54211   52674\r\n56931   45258\r\n96122   85469\r\n49166   78240\r\n62481   50848\r\n52959   22687\r\n63873   57830\r\n41246   73934\r\n14987   26979\r\n20275   70933\r\n86997   40490\r\n50744   79436\r\n65603   50527\r\n93444   73200\r\n36981   93096\r\n64981   24188\r\n54594   61041\r\n86282   82588\r\n52307   21180\r\n12918   51098\r\n75595   46040\r\n46294   32809\r\n42648   28822\r\n76701   73934\r\n39357   40254\r\n85942   27672\r\n30293   51731\r\n14554   43239\r\n12693   51158\r\n11550   59887\r\n34104   27578\r\n96754   67543\r\n27933   73934\r\n65946   82117\r\n94837   82219\r\n98106   24903\r\n20521   81657\r\n21221   80969\r\n83450   81657\r\n14804   80969\r\n83734   81657\r\n88364   96906\r\n92758   93858\r\n18204   85469\r\n60054   72236\r\n42828   50527\r\n15406   25425\r\n87075   51731\r\n50849   62481\r\n17547   46079\r\n30232   74633\r\n15698   75417\r\n31666   84048\r\n13207   85469\r\n94748   21832\r\n29373   56737\r\n78262   73934\r\n47166   85469\r\n37347   59963\r\n55898   51731\r\n79507   60630\r\n78774   35440\r\n21451   61732\r\n65454   19269\r\n11452   16533\r\n73216   48418\r\n18145   16533\r\n16788   96041\r\n98546   96894\r\n26627   51995\r\n20695   93679\r\n56907   28871\r\n91258   14603\r\n92889   77433\r\n80801   79820\r\n78650   87646\r\n89792   51098\r\n31140   37748\r\n39574   51995\r\n39472   47554\r\n47820   40254\r\n59553   83504\r\n48490   22863\r\n36237   24165\r\n17836   80156\r\n46066   56588\r\n50527   60911\r\n51432   71880\r\n60781   53484\r\n38705   97525\r\n32413   67821\r\n45089   89333\r\n49376   39546\r\n86247   82219\r\n39604   81657\r\n74016   54438\r\n22221   67945\r\n93946   96880\r\n43718   50527\r\n89319   65059\r\n82488   21832\r\n91321   30928\r\n68039   27760\r\n44307   48197\r\n94490   68981\r\n30492   98072\r\n58076   28830\r\n85970   99445\r\n59104   93679\r\n14040   20232\r\n26341   34118\r\n57767   90744\r\n88678   51995\r\n50242   62481\r\n97628   28822\r\n33051   98699\r\n16518   94212\r\n84499   65860\r\n46325   66381\r\n93073   85469\r\n94929   90795\r\n98809   87400\r\n17555   11615\r\n47520   81657\r\n15062   50527\r\n64677   34270\r\n60341   60975\r\n51731   81697\r\n62763   38295\r\n82390   29395\r\n48630   30199\r\n84290   38436\r\n75402   19023\r\n90846   86436\r\n74390   96803\r\n66651   21832\r\n79985   93096\r\n88912   31428\r\n95485   51995\r\n23118   98757\r\n16265   49141\r\n81649   67346\r\n49869   35440\r\n93158   51098\r\n59093   64754\r\n16511   99342\r\n87645   97525\r\n66377   11615\r\n56790   62413\r\n14603   99445\r\n22803   74917\r\n54052   35440\r\n86794   96148\r\n68298   97921\r\n83806   62445\r\n41103   51995\r\n90346   11026\r\n10908   47695\r\n40593   27032\r\n15356   18518\r\n93393   51977\r\n81234   81463\r\n19288   37691\r\n43891   77296\r\n12956   93679\r\n14965   77433\r\n49816   16533\r\n45157   93437\r\n67322   64754\r\n72918   16210\r\n23937   70753\r\n46885   28822\r\n95790   51377\r\n84208   14603\r\n89268   54904\r\n52277   87223\r\n95782   11026\r\n61182   57830\r\n25880   98072\r\n83860   87571\r\n77077   51995\r\n18942   19269\r\n23259   92845\r\n74151   40254\r\n52314   50527\r\n36861   58339\r\n80286   11026\r\n93258   97890\r\n44275   77389\r\n70783   50527\r\n84911   35440\r\n35930   14603\r\n73637   51300\r\n87485   71404\r\n56215   93019\r\n36150   18658\r\n19051   14603\r\n10481   77574\r\n21183   98470\r\n23123   42289\r\n97128   50527\r\n77494   72477\r\n26953   29420\r\n70483   81657\r\n70082   73934\r\n86376   30969\r\n18300   55221\r\n69060   51158\r\n28822   51158\r\n67856   63185\r\n86692   87303\r\n34069   48760\r\n88757   77433\r\n64044   18260\r\n54432   98082\r\n30804   56595\r\n58688   93096\r\n43156   65419\r\n95764   14603\r\n81486   28372\r\n97347   19269\r\n51712   26094\r\n44860   51098\r\n87037   35437\r\n35017   20937\r\n77387   12156\r\n10078   26448\r\n93279   44307\r\n63726   21832\r\n67369   83232\r\n40511   51158\r\n53691   97128\r\n93223   95795\r\n27426   19269\r\n81697   17090\r\n17316   54745\r\n27777   70728\r\n97550   30918\r\n12229   27313\r\n19269   69194\r\n60380   23192\r\n95311   80969\r\n69185   26864\r\n28494   93679\r\n18798   89001\r\n42841   39339\r\n81156   41727\r\n32991   51174\r\n22360   59706\r\n72053   57590\r\n64610   22687\r\n92005   64610\r\n53711   50527\r\n84765   52351\r\n88502   97794\r\n81562   68859\r\n31811   77433\r\n31346   73934\r\n70180   74152\r\n57089   74609\r\n81657   50527\r\n56823   35440\r\n36493   51995\r\n58649   38164\r\n23918   83815\r\n13681   57020\r\n90121   40254\r\n46842   16533\r\n22779   83532\r\n27839   93096\r\n45717   81296\r\n83825   75953\r\n80969   46369\r\n22683   56089\r\n73944   64610\r\n94512   95236\r\n60273   10018\r\n66859   57905\r\n19062   85469\r\n51417   11816\r\n61718   79256\r\n37586   35440\r\n58743   81697\r\n64841   95937\r\n58865   56423\r\n42862   30261\r\n37266   19269\r\n63878   85469\r\n89383   97525\r\n89715   63237\r\n96573   32832\r\n52655   92032\r\n78200   15062\r\n83808   45700\r\n35634   59352\r\n24255   68324\r\n35972   14392\r\n90863   57830\r\n95329   51098\r\n10750   85614\r\n16438   42624\r\n86739   34480\r\n90003   98072\r\n12639   39303\r\n84427   51995\r\n51781   76152\r\n34496   22395\r\n58148   81657\r\n88205   93679\r\n50741   51098\r\n31970   24540\r\n35382   51731\r\n62999   74924\r\n83963   31234\r\n18062   92202\r\n45068   94970\r\n39838   50527\r\n71520   28822\r\n51098   93096\r\n32346   49768\r\n92736   21832\r\n43323   95658\r\n58464   35071\r\n88992   50527\r\n67861   24097\r\n79531   19269\r\n49830   93679\r\n78703   30705\r\n80297   11026\r\n69226   11026\r\n38374   62481\r\n21852   18593\r\n96958   11026\r\n38539   21832\r\n32794   21832\r\n78798   97003\r\n96223   14603\r\n26071   21832\r\n39686   97128\r\n26048   70606\r\n70231   55231\r\n58917   75113\r\n62199   83162\r\n96306   59205\r\n48370   50527\r\n36171   93679\r\n82491   97525\r\n63363   91017\r\n11770   91438\r\n63978   50527\r\n50584   19269\r\n42407   69422\r\n21115   57830\r\n32805   97525\r\n33509   21832\r\n93002   28822\r\n85631   12807\r\n48612   96336\r\n72659   20129\r\n55590   27170\r\n75562   44707\r\n85043   28822\r\n96350   28822\r\n64571   35440\r\n36511   51098\r\n24661   40332\r\n43124   29084\r\n19676   64396\r\n70113   89945\r\n84453   82219\r\n18947   13232\r\n18167   52449\r\n42247   12286\r\n84728   12361\r\n41005   98072\r\n97350   28822\r\n38072   93679\r\n93484   54511\r\n10448   98072\r\n41958   49768\r\n66488   93369\r\n12823   81697\r\n25610   23272\r\n10701   82219\r\n53066   71078\r\n82561   98411\r\n55612   51731\r\n90428   50462\r\n75269   28822\r\n99211   16533\r\n21746   21832\r\n73620   98072\r\n68119   93096\r\n64999   58289\r\n24654   77946\r\n60698   38604\r\n37161   80969\r\n34397   51731\r\n36071   65274\r\n17585   16533\r\n34847   50527\r\n15346   95704\r\n96992   61166\r\n55682   62481\r\n37906   60636\r\n77960   76522\r\n76696   16993\r\n29462   81657\r\n57541   73934\r\n27197   58945\r\n82649   33263\r\n48806   71171\r\n82673   59650\r\n59803   16533\r\n73011   19269\r\n66026   51995\r\n10202   84890\r\n91172   65178\r\n89094   51158\r\n18432   65001\r\n47718   11026\r\n58437   91038\r\n69858   13129\r\n17056   58882\r\n55399   71128\r\n35040   73934\r\n42911   44230\r\n49894   51634\r\n11726   77433\r\n96397   14603\r\n77395   64301\r\n74358   78432\r\n82764   38499\r\n31032   51731\r\n71054   87172\r\n15947   73934\r\n47778   16533\r\n84893   28628\r\n25173   40730\r\n81302   36351\r\n83391   73934\r\n91991   93308\r\n31079   87735\r\n42936   40548\r\n14268   11026\r\n64477   57830\r\n67560   20743\r\n92460   51995\r\n59686   97525\r\n34154   85838\r\n63377   73934\r\n81133   21118\r\n73299   63651\r\n76007   93096\r\n65252   11615\r\n78949   85469\r\n20691   46712\r\n37742   33435\r\n87579   51098\r\n42341   79376\r\n57830   35440\r\n23963   98072\r\n65065   81697\r\n13569   97128\r\n23253   58502\r\n13073   15200\r\n84437   93096\r\n13349   76696\r\n86981   49768\r\n77821   80969\r\n96675   80548\r\n16781   62487\r\n43265   11026\r\n50208   41915\r\n16888   22687\r\n24043   91896\r\n88472   94959\r\n85382   19679\r\n99783   85469\r\n99403   27105\r\n67116   57861\r\n33393   52212\r\n45331   23773\r\n67666   80972\r\n75091   51098\r\n59305   19269\r\n23341   16186\r\n84540   16533\r\n21985   81697\r\n22442   20937\r\n58548   48172\r\n24586   39588\r\n60989   82219\r\n51489   94798\r\n49355   78539\r\n33721   51098\r\n95264   38754\r\n87615   99445\r\n68688   95604\r\n89067   98089\r\n29001   16533\r\n69704   29016\r\n55276   97128\r\n34718   84612\r\n26075   79610\r\n60067   15029\r\n40254   50562\r\n57647   65952\r\n58449   52332\r\n32201   71785\r\n87280   11615\r\n38711   32023\r\n95527   67518\r\n46099   92649\r\n69587   48194\r\n45658   93096\r\n75733   58939\r\n67169   25661\r\n29632   73001\r\n39121   63650\r\n16274   98072\r\n40942   37221\r\n59341   50527\r\n86036   93096\r\n83497   79723\r\n27584   20569\r\n21832   79777\r\n43372   80969\r\n16285   51158\r\n59831   11615\r\n54308   21832\r\n15628   30242\r\n98622   54345\r\n97525   16533\r\n18812   36681\r\n80016   51731\r\n52911   93600\r\n73344   51098\r\n33175   73934\r\n76871   18284\r\n17972   25169\r\n94667   98072\r\n19957   80752\r\n18041   42293\r\n97729   98072\r\n48346   51098\r\n80107   81657\r\n96427   94327\r\n59255   62929\r\n15990   56754\r\n51088   60450\r\n93825   18701\r\n44800   93096\r\n69429   99445\r\n16217   11615\r\n92925   17693\r\n12635   73124\r\n46330   98072\r\n76616   14603\r\n99731   16226\r\n40490   79655\r\n10872   79082\r\n18341   14603\r\n14770   11026\r\n99497   81733\r\n94474   51995\r\n36510   11615\r\n16051   81657\r\n12265   61581\r\n74626   14603\r\n10154   64754\r\n84889   39769\r\n78236   46325\r\n89093   21025\r\n79570   14603\r\n77063   62481\r\n71084   51731\r\n81110   91132\r\n83055   81653\r\n99853   73129\r\n11026   93772\r\n38393   85469\r\n63863   51995\r\n55502   72766\r\n94404   28822\r\n62772   51158\r\n69487   20471";
            left = [];
            right = [];

            var rows = input.Split("\r\n");
            foreach (var row in rows)
            {
                var rowItems = row.Split(' ').Where(x => x.Any());
                left.Add(int.Parse(rowItems.First()));
                right.Add(int.Parse(rowItems.Last()));
            }

            left = left.OrderBy(x => x).ToList();
            right = right.OrderBy(x => x).ToList();
        }

        public void Part1()
        {
            var sum = 0;
            for (int i = 0; i < left.Count; i++)
            {
                sum += Math.Abs(left[i] - right[i]);
            }

            Console.WriteLine($"Day1 - Part1: {sum}");
        }

        public void Part2()
        {
            var sum = 0;
            for (int i = 0; i < left.Count; i++)
            {
                var element = left[i];
                sum += element * right.Where(x => x == element).Count();
            }

            Console.WriteLine($"Day1 - Part2: {sum}");
            Console.WriteLine();
        }
    }
}
