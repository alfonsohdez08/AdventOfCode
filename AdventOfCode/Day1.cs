namespace AdventOfCode
{
    internal static class Day1
    {
        private static readonly string TestCaseInputPart1 = "1abc2\r\npqr3stu8vwx\r\na1b2c3d4e5f\r\ntreb7uchet";
        private static readonly string TestCaseInputPart2 = "two1nine\r\neightwothree\r\nabcone2threexyz\r\nxtwone3four\r\n4nineeightseven2\r\nzoneight234\r\n7pqrstsixteen";

        private static readonly string Input = "eighttkbtzjz6nineeight\r\n5knjbxgvhktvfcq89onefive\r\nhnjcrxeightonejnlvm4hstmcsevensix\r\ntrsdgcxcseven39dpmzs\r\noneninesixtwo26\r\ndppthreeh32twobhrqzks\r\n1cxklgfbvhsnccfive4\r\nfoursgjsevenseven5five19\r\nnrrk87\r\n63ntkjbvcv3ntdcptmvheight78\r\n7xv3one\r\n3tzjcrfbvhtqctfmqmdcbjhxln9eightnqbcqztmxcthree\r\nsevensszlgdrlrhnptonethree3qvrxkbgfxtthree\r\n3nckzkpkjsvztqkgvm99\r\nfourthreeonesevencqdv2gnvblhr\r\n528ksdcbx\r\nsix342\r\n3twozrfrtljql9eightgcqrgmbzz7dlcr5\r\n6five2threesevenone65\r\n4onejrg23sevensxfive\r\nfourthreecszzvhzfsevensix916\r\nspqzvdxxjeightninejzbpzone7\r\ncfivesevensix332lfpcffmld\r\nninesevenhrdvmzj24bcxxz6\r\nkhpn3fourvhqmntjxfhsvrlnvc\r\nbfzxhzftwo2czsrv\r\nmmblpnnineseven4gtfvqscghfour\r\n1zjgqlz\r\nfive1ninetjjtfxqpdkgrxtgxrcsevenkfdzlh\r\ns8twoned\r\n8fiveone53nineeightthree7\r\n926xrfcjzvpd7\r\n3sevenqnzjsqh6fnssjdsbv3nine\r\nrjbbsevenvzkghzsixsbjchs59\r\n221fsnxtbstone1\r\nseven9fourpdseven1four2eight\r\ntwo1nine4nine7\r\n9seven7\r\nfourcjmdgjsfive2l\r\ntwokvhrdldggn15twoxfivenine\r\nmmjtldgmvq157hchsnvpbjvrvtvnineeight\r\ncgzeight3sjmhdcvlnthree5vkgfmx\r\n8sevenfourgnxdpp62xx5\r\njgdk3z7mmkkjkm\r\n9xrdltttpqznsljbvcdvtz\r\n62zthreethree6\r\nsjbxq9ptsvjhpzmxfoureightmdbnlsckfqlqr\r\n91xrnsbxxsvk6brxfftpttsevencszfhsnrfive\r\ntwo9ljdfskpfive\r\n1seven384\r\nxbfkhfvlts8dhtnxhxgn93three7one1\r\n3xkjrnqnqhgcfgjvfmxhghp15\r\nnine9844\r\n5onepczqjfcgfrbmtstbqbktphkvqcmbbvhpld\r\neightsixhnsbnine1twonevrs\r\neightcmbm2zbxsixone34\r\nfive99qccjbklfivevqskhpxzd\r\nseven9four2kzkjbrp\r\nttdbhd4gqzdlqldnm\r\n9cqcztfourrsfskdjf\r\nnjttzmcrchfd4\r\nr414tzqnfddrbf\r\n4tzbfcjksjsn7eightonelvkjzkch\r\nls7four\r\n6eightsixrtkcrcbmqq6eight3nine\r\nonesix5five7six1\r\ndvrqseven5ninegqthree4two9\r\nfourgdkmbrlgc8\r\nthree7nine\r\nsixqrpzqvxd7xnbkftn5seven\r\noneonerbpgk5ljpqh5threevtpkpfxtsv2\r\nljttxthreefour3three4gxzgsfm\r\nsixttjvhdggbk357\r\neightlb4\r\nfourtwo4twonekzb\r\n8one2cdsnrbfxbsixztcfour1\r\nldveight19lg\r\nseventpd84dscfmxj\r\none34flpg6eight76\r\ncfninepkscscc5\r\nflqv5v6twooneprlprlkcbk\r\nqsqlrvmkq5457ninetwosevenm\r\nxlvvtxgspct4gmrgeight\r\nhpbbkqthree4gzbq768five\r\n5dqfsixeightonenine\r\nseven4nfshmhvgqm4\r\nrhfgvzxtfckbtmxtt9rqms9one\r\n3gsgfbrnkhqrjddvlx59four2jfz\r\nfdl4two\r\n9sevennine158\r\nfive9eight49\r\n3mfsixnkxdbpdxqdgfdqnk\r\nsix9fivefive\r\nfourjdmvlvkrp5seventhreejnqncmktwonev\r\n8cjfqkkgtzlnine\r\n3nnsevenjdbjfp1\r\nghthree1mhgtklfqdkqthree7seven4\r\n4mqsstftj\r\nsixprblqsevendsxvqnk5\r\nfour45one\r\ndxhvj23188xz4\r\ndcmnr2\r\nxfoneightsixnine6fiveseven\r\n6cxbbxkrxphsix\r\n5ckkzlzjngvssfx\r\n223zgb\r\nsix4qsf\r\nhfxgsfhfhpjlvb329eightone\r\n9zjkckhxoneightbnj\r\nxsdp23seven3four7\r\n8five53eightthreenljbtgcnfive\r\nfnjn36\r\neightkpkxrvssix2lhctc\r\n6ninebqcksevensevenhk\r\n2one98rrtlncrxhllbgthreelgvkdf\r\nsixzdnlfrvvd4\r\nlltjs8sixqbblmfdhctwo\r\n6twonclq98sscjn\r\nsix3niners7eightwokjj\r\nsixeighttwo1onerxrvvbfxxqmxnq9\r\nconetfpbsrm81sixsgkfqk8six\r\njbqs5277\r\nkjbncjlqthxzlznld89bgqgkxfzpqsptwo\r\nonefive1\r\npchlnspk52one4sgqj\r\nzd3\r\n43fsfplhgxtjthree7gs4npllqvll\r\neight8sixeightone6onexr\r\nsix6hqltskzpkgbggjktlzlpktdqhzdbnine9\r\neightnpfbmfninevgpjsleightxh3mz\r\nrninenine7nine\r\nfourbbjnjrbzdvshfeight62\r\n3hzpfsfsdm\r\n2vzhjbv6\r\n27bpninejhbcjrmz7zfqf4\r\nppflreightpmztvhvonetnjmrxdd31one\r\nthreeseven7\r\nsrf5hcxvhsmn5five\r\nonersvqvqgkfiveeightqxgrjgfcqj5ntgdzxp3zxdcmbsjqn\r\nmcb643fivetwo\r\nonermbkvmkc9pfvlpdhkzj\r\n3oneeight64\r\nqtnptg5two36nine2tprkbtb\r\n15lbhtcqfnj1qgjk\r\neightkzrnlrrnlltdmxlbxfourpbpghtgkb9nvlvsm\r\n26kmmkz\r\njhnldxdtpseven46oneightnb\r\n4lfftjtbzvppxsix17nxpgvjkxd\r\nvszsbxdzjfourhlxldrthdzpqg6slnj8four\r\nnineone2njsfpcb\r\n5sevenone6five\r\njrmdhdvrb53onelgvlkd29seven\r\nqqqg7eightseven\r\nsevenm9\r\n3dfcfcdb9twoqbvxjgt56six\r\nxq88jjmv83pspctxthree\r\n38five5\r\nsix7rbrvjb\r\neightlvqn335nine\r\nrgmfflzxzd9hs3foureight5\r\nqm6qvmrone4\r\nfournine8\r\ntwo688qqdtdfbmzn5\r\n8joneonefourljvbjntkngtskcgfnszpgxt\r\nninethree5pjzcvntl984five\r\nmfgqzcjbglx7\r\nninemxnfcqrbjonek1nineggj\r\n8dcfkfdtwo\r\n4cltttbrlzpgzbdbqsevendtwosspqk\r\n8eight9klmcbninetwozdcznsv\r\nsix85pjqldfbqvclntpnqgv\r\n1dgprzx53\r\n4sixthreeh3fjqpggtjzq\r\nfourone8fiveseven4kgbs7\r\nseven64npxthreeonefour\r\nxvntvgxv9twotlgcsbgsix4\r\nhcqtdzthfour2xvqmnmgrncjt51\r\nqhlpksvnntjq8\r\n3rtmfngqccktwovpppqfqdlxmk2\r\nsixfoureight9tqpdln3eightbjnqfldblnine\r\neight2sixthree\r\n3plpm\r\n6two3two2\r\n1cfszpnxgtk5fivefive8one\r\nlxrdvls2\r\nsevenfqszrfhone5dxcqsq\r\n42\r\n3dmpsix9nhgzhbmknfour19oneightlng\r\nsix2dfglxszbjone\r\neightone88\r\n9hffzxl7five4\r\nseven8fknjk\r\nfivefoursevenllljzrvjf7\r\neightmsxfkbszh2\r\n6fiveqhkttbsthreefghn4\r\n3eight98vsnzbkvzcjfive\r\nspmzsdztzgcfbhvbzqlv5\r\nfourtwozlsst9sevenjjmbmqk4\r\njtmlgrjcpkone2twockgc5four\r\none35five4\r\nfour8tltpxqfour\r\n57sevenbmhceightbhttrzxfvt\r\nqlvrrlnxgvjgnine1four2two\r\nsixoneseven3sevenm\r\nfivejxfghfp81two\r\nrkp3zbzfnrrqfour4eight\r\neightnine7tpflkbqpz\r\n28fourlmxlhdzctxkrsix\r\n2fiveeightnineninexhfourseven7\r\nmnlrszkr18tfive7l\r\n3eight639\r\ngqpbkntddpeight22lxqjqqone\r\ntxxrdbx4bvsfxd\r\n343nsctfvndmp93four2\r\n9lqjvtjcrrtthree\r\nbsffrmtwo2fivesix\r\nqltdtgl3eighttwo91mjq\r\nrh4rddsfr\r\nfourfive7seven\r\npbqmx7twoqdk\r\n6onesixclklzfzsq992\r\nkzxkxvqzjffourdtm4onefive6xoneightsnl\r\nk4snine4three39\r\nsevenone2xcnscqhcdplnonekcxmgt\r\nseven7ninepmeighthqr8\r\nxpspdx3twoqpc3881\r\n5two5four8eightfive\r\nsevenseven2bcbsf\r\n1sevenrjstpdxfiveseven\r\n2zsxfivefivesix43\r\neightone5j99nhvbfqhzbvrv5\r\nonefive35m\r\n2kfnqftkkcxtskj\r\ntwoeight8\r\n1one8bzzsmgvj2kmqcnqjrz4\r\n1one4sixsixbzbcglm\r\nfiveqqhbmnjgz5ninerlrxkl2seven\r\n4eight4two1xgkb91fdzgxlp\r\nnine8onefive5scxlfrf\r\ngbrqllhnine9\r\n1fouronesixfiveseven95\r\n7qjrprpseightshfzfxvn\r\n2vkbbxfrthreenineeight\r\n58three4\r\nlmfsgdzxnqfdbxtjsnp9\r\nzlbqglfseventprsqvsmt1one9\r\nfmksmtlc8dvhbtdvpfgdz\r\n3six1\r\nmkdthree67jkprftqhdzvjxxftthree8\r\nbstlpptcfghsrrnine7bz\r\n5m1qfscxncvkqgtf\r\n62four16threeoneightg\r\ntwoxlrhpc8n9nine\r\nq5sixfour\r\nninesix2ninepzvxxlpcbxsfpz28hxtccfzmdq\r\nsevenccq4npgpkkb\r\nk79four9fp\r\nssqptjqvld1pjfdjnkvsevenkjdzks\r\n2bgpbgqfournine614\r\n16threeeightwot\r\nfive68jnhzdfqp2qlqbmnjmjdtfbj\r\nvplnzg4545seven\r\ntwo3two\r\nzcbhzsvc68cnppjpqhfl5\r\nnine68seventwo8pfzgfzbsh\r\nonethreethreeknngnmzhpmlnsd7\r\n46two\r\nsixhdg748blmlkbdtjbtwobgpzzlhzqrbvl\r\n2smcthmql84seveneighthnmdkmfg\r\n5fourrpscd3\r\nsppzzjbckgsixone1sixfour\r\nltkzb3v3ltwo\r\nfour61nineeightdkgtcjfvds\r\neightd5nfcvvdxhkkddhb\r\nfour6q7thbpnz\r\n5rknhshlhgnzz7sixone1six\r\n327rkthreesixeight\r\ncnbqtvptwo1qnsevenpzqh\r\nthreeqthreepmhgcqhseven2sevenggmpjcldz\r\nninedlvlgnglqf3\r\n4two993ninetwo\r\neightzpfournine72oneseven7\r\nninejdfkznz62kflbvgpblcgchpzz\r\n448\r\n6rktvxxjpfpqtntbsonefive\r\n6lngttwodshgtworkvvsrnfhjmvpvvbseven\r\neight43gpssneight\r\n6seven3threefourninesevenrnxx\r\nthree22rblfvqjr1four5six6\r\nxtdsqqbv43cxxvfpvtwoklhnqgjlkrrg\r\nthreevpvxgddmhl576\r\n3cxccdsevenmvzhqvpfn3btldbhbmfg\r\nkklcmgptl931threenineeight\r\nvj42ntvkrcjtq7sk6\r\nllsvqthreefive5\r\nxspgshknq3kpld2lfour6mhzrzvqf\r\n4bfl38onesix9\r\nseven1vjzjmcrrvnh\r\n7sixsevensix\r\ngqnkgzmvpsnnzcvldlftrzhnpcbq6hzvbqbmnqvsix\r\n5jvbldxsh\r\njrmvplfive7mfpbsmklzfivefivelsm\r\n8seven5nppxjfjsevenbxrmzmdjnine\r\nseveneightnrkconeqgjfkxjr532\r\nm9seven7\r\nvdn5hdghzvphfour\r\ncpceightwo3\r\nsixtdxhninesevenmmzrpdqcp24\r\ntghjrkhltwojgrcnnbbq1\r\ncfrqlvsevengkthnsbtwo4twovffpv5six\r\ntwo6pcxj4eightgbctk71\r\nfive93nrqpshmxpbdnzssb2\r\njnxjdzm2xcfhnzkxxz948twonejv\r\nsixfive4four5nkdxzvd\r\ntwoqvnxzgcg883fivejgvltjq4\r\n7mzsqvrxlf6kpfjgvdpvj\r\ntzhkjn813six7\r\n5qjbtklseven\r\nrddmfnjgdlnkx5fourzkxlttqdfourrrjfdd\r\nqtr2qrrqvhrkvmtqgbkdq\r\nfive56ninesschfzxone\r\nlkb3\r\n3zmbbqdqqnineeightlvlfqqxleighttloneightv\r\n7threetwofive168\r\nnjxgnsqcpnine2\r\nzthreerfnvvone7\r\nthree4one8\r\n8ppmjj983seveneight9\r\np4\r\n8tshsgmkb516three6four\r\n7seven8\r\ntwosixthreenine6three\r\ngvqz9\r\nn89ninethreesix8\r\nptqrhhvztxsjbxfour81lncqpkjt\r\n8flvhqljqpmlf6fivenine28\r\nzhbsl7seightwoczd\r\nfour1pspgxdvtbzdcd7vsbkzmt\r\nfourj9sdnqtwotwonine3ftzrbzckqk\r\n1fourkkfnndsdxnklrl\r\nzpcdvrszc4ggjcpngkqeight\r\n6twonxhgzcsrgxtwosixvblddxgfmsmqtfcthree\r\n6pltsptthreefive5jjqtzncslmxrmbv7\r\nsixfourqfxtfour9onefivehsgdvpmdsfive\r\nksevensevenonebdxdxffive5threeeight\r\nzztvdjzlnqtbrfccctsknppmx5seventhree9\r\nsoneight716\r\n1fqnntfjhcj2threekmcpzqnbzlqps\r\ntwopcftkx8twofourcsixfour\r\n8six2sixgxzzhpkv\r\nfour9nine4tgq\r\nhtfmtchrx634four5zsmkmdv\r\n45dltlvdvv\r\ndtl848three36\r\nnine7sixonetwo8vsix\r\ntwobxctmqvdnt96mnljbpxtsptjpznrjctgtwooneightqv\r\npeightwosixeightseven4\r\n1seven8ds4five6pone\r\nzjftdkvpkpfrhzj97nine56\r\n4sdcdr53beightwocjc\r\nonezxmtfive7ttbbttjeighttwo\r\nrlcjone3sixonezvbmzcgpk4eightwotnm\r\n5ddmcsfzhntpnzntlllthreevqvct\r\ntwoeight9\r\ntfhmxsbf2foursqrrfourmfrzjffive6\r\ndhhnlbkjmfourthree6\r\ndxtkbxjlphpqcbmhpdfpqlmreight775bh\r\nsixklvmtjgsevennine33qgvplfourb\r\ngkjmcxsmhtwopkcszlrjd1onesevenseven\r\n8xxvzzqvzszcn1onevmdfsrrtbbjgeighttgpmhh\r\neightpndprhrf7\r\nthree7fpxtxghx\r\nfivenssevengrrlntzldl87\r\n484sixjsxcmmtvbftrfive\r\nt8onesevenvqsfc2k\r\nsevenoneoneeightsevenfive71\r\nsevennvnvbtzsnqggrsrgq35sevenfive7\r\nfeightfive12\r\ntwoc846cf\r\n1mtvlxhhxlsdbphgltlgzpl\r\nxddrlslrdl9\r\nfiveqvfjvcqlcfour27\r\n9fjqp9rrkqbtpv3\r\n23fqccxsvsix94tkzsqmrhsg\r\n6lvrsqnz\r\n9four7hvlfl9\r\ngbgsnmkrxjxpgnj828\r\n56grzmb6onekf9six\r\n87bjn4\r\nsjdzmqkrlkbsmxzsmn3\r\nseven91eightsix\r\nsvhfnxzdzqczc2\r\nvbnz92chjjfqftxfourqzzxseven\r\nseventwofour5jbqvlmqknbznfbhtonefour\r\ndqdmntkfsnbmjqxxgmkvm6vqpgpnnreight\r\none1431\r\n1five4\r\ntwoone8thtxlrrdxbone\r\nqftpltmjd1zpxckthreeeight\r\n9xg\r\npjpdjrkltnrkkmd9five75rdctppdhjtghrffczdx\r\nmtvbhnpzjfive7nine\r\nthlzdgxcqvsknczrdslsh7\r\neighteight4kkt7four5\r\n71ninekzfntxtjthreeone3\r\ngzseven2fssqrgmbj\r\n52j\r\nnsv16seven\r\nstwone1\r\ntwodbqgfivegsrrvxvone3\r\njckhqbdlvgbgn7vtx3vggrdm\r\nntzftfhfeighteight2\r\n48eight6\r\nflzfqonezvskbf1668one6\r\nsevensix864eightfour3\r\ndnsdrsxvcxnsevengxrszqxfnd4fmnine\r\ntjjngfourhdfzpfkh24\r\nfoursmgvlqjxsqmz8ninekthktdhz\r\nthree435\r\ntkfqhpz8zjmcqbxcb46\r\nmmvstlmln3kxnkvjcmxtrdxp4seven\r\nrmfour13vkgnnmbzbzgd\r\nthree6nnbljchmzthreeg\r\n68onep9five1one2\r\nrbvzvgmkbmdrnmvone7kqtxtrtbone\r\nthree13six4\r\nqksfrmvgztsfournnvp66nine\r\n34three\r\n11fourpzkmqnfmjqkdgrlgqbsixsixcqtgdggbdx\r\nnineone2seven4twoninesix\r\nninez6qpnnbpmcdhcr\r\nsixbdbkhgntpsevencpn3\r\n1fivehvlrzpninemkfbfgtvfivesix3\r\n7kpeightzlvqsgkfjznpfpfsseven66\r\nc7hxrgkglfivebfctxk\r\n5rfdxgshzmnzqscpqzlbnrhbg9strxdthree8kntkhdpdll\r\n4gfzcjcjsm63fvxpvflv\r\nnine8526\r\n6scslfpnrveight1seven5bdllknjj\r\nseven94hnxddjv26s\r\ntwo48seven3four58four\r\nfourseven1smh5\r\n1zzdzmbjpjfzlhsvzgxf61gvtnklgx6\r\nninefour63\r\nnine3nrfzn\r\ngthreeseventwonine1eights\r\nsdonejzdmtxtpl9onerzztvqr8\r\neight15kqnjrggpblhsbdz1\r\nlkkxnzjrgsixsixthreeeighteight4twonem\r\nd17two44\r\n6seveneight1fourthreesevenbdpvg\r\ncjgchvhq4386five8\r\n1threefive426rsxmthree8\r\nsixnztppjtn9twossfjrdkzkrldztfbbv\r\nthreesevenlqrdmvzdcphmqj3four5three\r\nfivethreepcfxdxmc3vdbprghd5sevenszprlbzrbn\r\nthreethree88xcgdmrcssevenrlflv39\r\neightonezchscllpfone9\r\nzreight6sevennine\r\nfmrhqrxr7\r\nsixnlqccjchpxpqg86five5\r\nsdpxjrxtk4sevenfivetmddbpqgtqffive2\r\nhrvrgjgvxt7vrsr\r\n2zj8\r\n35fourspthreeseven3zgddrmbxmsz\r\nfour8kkxmtsscf\r\n4six98\r\nfive9four\r\nfour5one7pjbninefourbmss\r\n4sixsixt138seven\r\nfourxsevenseveneighthsgmmpdx5\r\ntonexhgcjxbjn8\r\nchbkd2183\r\nsix8fivefourglszgngfgqthree\r\npghkzrftwo6\r\nfourpfx572\r\n62zfvzp\r\nsixsixnzvtxdgsixzxsgmpz1zvtwo4oneightpg\r\n425twothreebv4twoxbx\r\n8nineeight55eightflkpggltsr4spl\r\nseven45clkrkrxj\r\n65six594twofive\r\n4ktvpfjeight\r\nnnslpmkqc5five5four\r\nnineonetzmft8jcxqzrk\r\nfivefivethree99\r\n2l2\r\n4mhdj\r\n3eight7fivejqhvrszgh3\r\n5four7mbfz8\r\none8sevenmltbgqcbq22\r\n1zgfnfvt9seven\r\n2lhbfrndhmfiveone\r\nfivekzgch424zbpgxhtkbjdljxkxvnz\r\n1vd6vpmzjmnhhn\r\nvlqcbhskb5onerqbql6\r\nsix3tplqcxthreethreefoureightzldgvgxrthree\r\n4fourtwo4\r\ncvznvxbxlszjpxvzbqn7gt2fjtxddzmjv\r\nkjqthree67twosixfour4nine\r\ndmjrhflfzslhkjmthreemfgqvzcpm9bcnfbpz\r\nnfpcsevenone3two58\r\neight4kdqczz96five1four\r\n1mzfour\r\n57tdcmtmns4\r\nbdxeightrjvkrddrm3nftmzxlftthree\r\n2three2kvfourgrtvxmrzgdninecseven\r\nthreemxpfnthree5onehjdxfntvtzlxhr\r\n8onelqtjpkmtwotwoseven91\r\nrzhzg1fouronecqkdpfkgdkkftsixhllvphvtjv\r\nvxgrlptk48one14two\r\nkqncz3znmkppxs3hlggbmsfj81\r\nddrp3\r\nthree8hjdccgthrtbd6lvhnbfivemzh\r\ntwomptzvkqmssix7bjvpsix6nine\r\nphrdjxmzj3xxkmfour7dsix\r\n5threeshtmlsjbmfzgdq\r\n96eight\r\nthree6rqqxgzthreejphvs\r\n69seven52kmnpbqmjdhtjvxcnlxfgldbs\r\nveightwozbbcmqrdxv6hxxpdknf\r\nnxbtwone1vktdvlbbhnfour\r\n4five864\r\n2dn1fiveeightthree\r\ntwo4twofoureight43\r\n1eight51\r\n71fourhjrnqssxqvf\r\nsevenqxkccdxndfgqhctsfsx6\r\nxqgsjvdmnb31sixfourtksqshz5\r\n4ghkqfzxceighteight2eightfiveeightwotf\r\nninelsnldgslfxfqfsrc24six\r\n3seven3ctbf9eightmshd\r\nmbqpfourfive44sixbnmqrmkgxt\r\nflgdrvjj4dks\r\noneqslfbjgfx8\r\njmmssm2\r\nhjfbzsix1\r\nbvjdxseven8\r\nfivenhfccvg9\r\nfour5sevengkvslppponerhlvfms\r\nb9one\r\n89znlhgbnkmmxsix3two\r\nsixsqtjcdfbs87ninejvznvmeightfvst1\r\nsevenktnzdkcsrzzdqtb9jnbtwotgxsptxcd5\r\n6mqvbhsddnmb21sixskg8\r\nthreenb2four74five1lcmdzrvq\r\nftvone7\r\n5msevenpdqgzncvzxeight\r\nfoursixpshnbrpm64\r\nsix2twotwordzf\r\nnine7lbnxsfjtbb1seven4ggt4\r\nzlnfkkconept36\r\n9sevenfqlxjmts94xpcxqseven\r\nfoursevenseven15ninedqff1kmzfgvnks\r\nxktjdhb115\r\nthreeeightcnlpzrb8\r\n91six\r\n376kkgmlblrcbthree7jgxvgfcdv\r\n9xpz3\r\nrrcvpkgtwo2one6vjfone24\r\nsevenhfour3three\r\npxfvzltqrg9twotwogqdtzbp\r\nlrgseveneight5pmxvppjdhtwoone\r\n97six\r\nfour8bjdhpmszdeightprkgone\r\nmb6lfcdkcn\r\n8fbvxnjone\r\nz9vdthreethreesbsrkzgnsxp8\r\nsevengftjmm1onegqhpninesnr3\r\nf4fourrbbngrdm37five\r\nninerbmdqfvkfx9eightone8eight2\r\nrxdvclfr714\r\noneggchmt2dgh7\r\ntvbfour9four\r\nfour474fourgmdtm\r\nnffourpbxtlcs7ninethree3\r\nbpjlrztwo2sdttcghc\r\nhfflhmdc18\r\n4ninepsrmtbqrfeightk3xxxf\r\n433hdvcggkr1xjcntvtnvsc\r\n7nine2nine6\r\n9zctwo\r\n9vvfjvctgtzpjh7jtdjcrh\r\nqrtgcd5six31khd5\r\nfourbjshrq845zg\r\nghconeight35jljdqgtg4fjdtxtsfiveone4\r\none7kxscgcxnsx\r\n43threethree54four\r\nvmninetwo2onetqgblrsgcpfkrreightwokg\r\nthreefour38\r\nfivesixeights26three\r\njtmzzxvmxone2four9jgtxjrvpcthree\r\nfdqgczkq8sevenvcnhpseven8three88\r\n7ninezone3\r\nfrj4eighttwobgx1threesjckzsvvxlone\r\noneseven2cspzhqfsix4\r\nljmnbbcnxffkmdn5\r\ntmzlnl8oneseven86ninelbrzjgqn\r\nfthree3seven6sixtwo34\r\n6two8fivexteight\r\n89seven5twosix63\r\n63pzsjcjzvbhseven\r\nmsqvppsgnfbjrjmdrrhbfxrjqdlkpfourjbrjks3dthree\r\neight6twoklkdfgvxzteighttctqz\r\n4gjpfmqs233six\r\nonefourninenxcnkgfour8rmmrzln\r\n1sptlpstqb6eightqgfhzzgpgp24\r\neightlrjlhqfoureightjvj937\r\n595oneighthpt\r\n44five\r\ntwo2sevenbtwo\r\n7fivefivepxonebbrlthreefive\r\nklxnlfjlsrgjcd7eightninefive\r\nthreeqzpptnzhjnkqfsixpvk3xxlrpl\r\nmqkhsdtbqqzgjb7149ninesix\r\n1dbrrvjsx34cbdxhqpzbfhtgpm9three\r\n3onesix6eight\r\nfive34\r\n6qcv9nzngtsjv\r\n9lttthreegttzjstt\r\nfour47\r\n95onetwoftdzmhsfmhbnblnine\r\nchcsqhnp72qjdqtjxzc8fourfourfour\r\nfourfive28\r\n81eighttwoqdjkmnleightdbmzz\r\nvzzqpjx8\r\nqq1six\r\nqbktqgrjcqq75\r\n772\r\nnjvnhnzdz6threefivetwonelt\r\npcfzzjfhqkxhfpztpv7\r\nfivemztfourqjrtngrkpcbfc3qq\r\nbfjhbm6ghtdpsmlvb86eight\r\n94883\r\n6onegbxmcqmdfive\r\nsevenonesixcngsrgcz9\r\nsevenzhxktd22fourgnr9\r\ntdxpzvggnlpdxxrcpsp3threexjrldrkmp\r\n34kjtbsxppmxfoursixlbzgqxbltv\r\nfivethreezfive2\r\n7seven1seven\r\n4fhvxbg58eighteightone\r\n631gqtwosix\r\nxqn1chrcjjrqxp4threezjcd\r\njtssvppxlnsix49rfvjdzntwoone\r\nsevencmpmdnczcfdprgfdbjnzzkgnine26\r\nhkbnggqfk7mfmfsone68sxpdmf\r\nfourtlhsmksvzg4foursixseven\r\npprkj3sixseven\r\nkzxjpdczxhxckxtgbbtwothreethree5dztmdfrlfivedgcfmmrt\r\nhjvrdhnckspl5eight3three9\r\n74two95eightfourdkzzlkxszm\r\none7tbfour1cpjtrxsqgvbjtpbcct2\r\nfivefour4hsix8hjsxrmpqqxnkhmjseven\r\nnine8fivehvmnxsfour7four75\r\nsjfrjr2ds\r\nfivefourqt95vbndnzns665\r\nsixssbznthreethree6f8lnzcgpprl\r\nninepfbpfnflrfnpzhq9\r\nnh9fvrldpkjmq7six5p\r\n75zsixnqbhrcbpmddshjfqthtq\r\nsevennine377fourfrtvpqrseven6\r\n97eightnine\r\n52fiveonetrq5\r\nthreehgjqt7rvfsljtzkfour\r\ntjkxc1\r\njthreerqbpzpzmeightntjlrhdmfour2\r\nfourmgv2three4one\r\nfour91\r\n9bone\r\noneseven1sevenpdvdqhlq\r\nxlhbqxcpfp7\r\ntwothreefive43\r\n1ctjmfn9one2\r\nhtfivesixcdkjrjbr45eightseven\r\nonefour8rrhltfl897\r\n37ljvmcnjhonevxkqpjk\r\n3891sevencfgjhh45\r\ntwoone5tbznkdmv1fourpltvnnsvk19\r\n55bcnzbfggd2\r\n17zpskbgeight2dx3\r\nvbdshtdkxllttwo65\r\ntzvmcmltfphztpplrxjxpbnine3qvktlctfrpxncb\r\n1sixppzlfvkbnm\r\neight1gdvlzrfkc\r\nfour74fivefseven\r\nhlzlvnjrp9312jxeightnine1\r\nsixsevenkjpbz5sevencksb2\r\n9rtvlgdpfnmgzdzcjggsq7sevendxglftncmbninefive\r\neight8gxkrbkgcvbxbbxlonefivesevenjnffhjsk\r\n99twobdmcnfthreevr\r\nsevenlpjbbthree58\r\neightthree32\r\n14fhxsqshmjbngrhdzvxvvhxgvqnlxnnvrsgsheightninenine\r\n6twotwo\r\nkr573eightseven78\r\n9six18\r\n2seven8six1qdvf\r\nones9three1lcqj2\r\nsixbfour6gbd\r\ntfpvtbbjtwormxz6\r\n49eighttwoonesixeighteight\r\nfcrhntggdvseventhreeeight9foureightxjxqvtb\r\noneone3rnngppxj8fzpsncjmzn\r\n9fiveonejjdpthreetwo9\r\nsixsixjzckvmbbszsl1nrrfphj5\r\nzgjvnttth7sbmtxczggxbbqpzq467\r\n3mhslltk\r\n9six16three79three\r\nfxprlhbm3zljzd49gdsrtt\r\n6eightoneseveneightfourrfive\r\nfourfive11six\r\n6gmrfxnsmnnljf8ninenlctx\r\nseven5threehninecnhbkgbnvqbsfx\r\npxzccjqz8\r\nxgzpzljnfour7threethrxskjlz9\r\nfourseveneight292eightone\r\n5bjpzjseven21four\r\nxbtf88nine\r\n6nfjllxh4\r\n67five4c8\r\n1qbzdkvmlrzgj3rzqczz4\r\nmjjzblg3\r\nx3five\r\njrpxsrqgr9hqsddmscmsrsbhkdc63eightxfscd\r\n6eightsixone\r\n5dggfbgclz7htvpcx1\r\nonethree46psdlfpgbsix\r\nlqbnine978\r\n7nrrdzfksbtjlnbgfxttzfourstqkd\r\nmtfptwo9six23hctpbrxtbx\r\neightfznvmmp7cllpkggknttwoxbbv\r\nrggdrlsgcm2hdljxzjhjrfour83\r\nvhtmhvjdzzkzmzqgr7fourfourfourgzbqqpz\r\ndfjctmlnkqzzjhhltpvhfmhsixvclfive7vgm9\r\nnine642sevenseven9mblrhxxktfhdhbcztvx\r\n4rzrdfmtvlpthree86\r\nqkdoneighttwo1one3\r\ndnnvkvpcmn2cltbzc6five59s\r\nsixsnzpnfplrn38hthhbfive4\r\ntsrxkzfxcdgckxrgzkmrctqvrngfnvdscnpc6jgszldglnhsg\r\nvvtfhtgxjbdgznjjzqjjclfg1lvpdcpjsevenseven3\r\nxrhbrpg8zb8\r\n4nine5qfxlhmvzsjsbznmklseven\r\nlffl2six733jtrfrs3\r\n7nbvpkdpzjtc8qckhbqfsqqgz\r\ncfljnthreecninedt2xldzbgl5six\r\nnrggf7four\r\nhbkpxrxonetwo969fivethreegspmzcfr\r\njjpmzlzfvqbvbzqcz2eightninepfqjkjrkfivebzcthgrpqx\r\nxsccsbmcninefive4kkrvrht\r\nsgnzzschtwotwofzjt9seven\r\n8tworpzncglnmninenjmf368\r\n2one1zjtgllvsone\r\n7nine4nqqxnvvnsbsevenvddcvfdr\r\nthree117\r\nshcjhvrfourpthree12\r\n1zxcxninegpdfrfhzlbzg\r\n7eight9gkkfbdhplnmjkksbqzp6htmbhg\r\nsixeight76sixfive\r\n5twonemt\r\nthree86\r\n4three52psgzhnlhgvgcsbzbleight5oneightkj\r\ncnztwone1\r\nsix9sgx\r\n79clrpmeightninepkh39\r\nrmfplpsixsixlvrdbqgpljgl5onetwo3\r\n7ninelznqjxjgtwohhk6five\r\n1659two7onefive\r\nrskpnrmfbbghttvklkg773fourczdqeight\r\nxftwo4\r\n2nine5ccrgsmfcseven9seven52\r\n8sixseven\r\nk33threehgqtljcdqxkl\r\nhfgdvngttzfivecflmcc31three\r\neightninethreensjxxlzhgk9b51x\r\nninejktfhnnphkkgm2dms5dpxrbcd\r\neight7skzllgxgmkd1three4thhdpsjtvnq\r\n7ninehhhdngbxjvvxldvbrhzrbvntl2\r\npxgsixone75llslx\r\n31tgrvtvvlbhnshjfgnqc\r\nknzgkjfckf2sevendfive\r\nbmxcnznineeight9dvkbngzmxz\r\ngzqdjfsxq9pbseven\r\n212\r\nh3\r\n9sixfourbrfsfivekttxzhrmdsppps\r\n3vxtbtrzqzxfhgsksbvqd\r\n9lbxdjmckrhfgjqlnsrrfzqxktqkrmmjshfnine\r\n7pjmmxdcffxgspeightgpdcftjtdxjgdrfthree\r\nt84ninefive4\r\nfgfour63sevendmtrrc9\r\n64three\r\nbtjnc3g6f3one\r\npm9\r\nthreefourvjmsx5four\r\n14one2rtcccqc\r\njhcckpv84xntpzdn\r\nrpjrhgddzfvrzpqnfg5twoseven3threehvcmnkreightwotl\r\n74one\r\nsix4ninesnbxlonesix5three\r\nkfxjzjone76xppxgddstgfhxphpffrjlone\r\nsixthreedsdccpqff4\r\n4951\r\nzszgqjxbx7\r\nthree4pqqvfzf622\r\nvc77threetd\r\nsixlbglxqhn52\r\n1sgktgvxp\r\nbdsonekxsevenpgssslcq3fgp7\r\npvnxnhdjmndnhthreefive49\r\nkgvkszsixone4\r\n3mjvqjpglzhphg67ninehnnine\r\none6xvvnvkxp4dfcxv\r\neightfour7threesevenp\r\n7ggdl1\r\nztwonethree427ninetnmzntj4\r\nfttwone258seventwotwo\r\n75sixseven59\r\n7kmfzqgjpqkpdhthjlseven674xdgmphfk\r\neighttwo6five7\r\n3eightwoxg\r\n22434five\r\nkhjmcpzvfpr9\r\n3rrzqzlrljgcvdnxj6four8six\r\n63qrgqklszpgthreefkpzx\r\n574htclbtzfivetwo\r\njtwofqfpkflzt9\r\nxnjzxpmmdln4lzlmlk41\r\n6jdzjjmz7jt7seven8fourkgttztbsktwoneps\r\n72s166zpslq5\r\n3553lhkdcxvhqbddrfdbc5two\r\n4gktbmone\r\nfouronefives3qhglmzttwoeightone\r\none87rxkkhfrjfrpdjjt485\r\none437nine\r\n119one\r\n5lseven87nmxxqvhmn\r\npphfmcfhxlsevensqdmtvtpvq1\r\n18eightfivefour\r\nthree98\r\n4onephzhtq4qc5four\r\n26zglkpjvz3twoeight\r\n7mxkdrbpnk29\r\nppeight15\r\n9jnprvtmscsixbbpsixfivecktgvdpf5\r\nlbftvcngvkvxf5cmmrqljjb471\r\neight3knrvtwo\r\none6pvbpkqkpdsixbv\r\neight2onethree6eight\r\n5rztcbtfjkb2twoeight39hxppvpxqg\r\n8threemlllncmfourthree\r\nvhtsmncssixbmlpggvmlzdxbczgc1fxrgvsbhsrbs\r\nninebnpv7575three\r\n4mthree\r\nfourtwo1qrbfourjrjmlxjr\r\n3jbkcsrqznc8\r\npcgrxgf4eight54\r\nseven5mjk\r\nninenine6vmcmlxmcrbvq1nine8\r\nsixone2ninesixrdqfgpxddzthreetcheight\r\n899lfbzhgn151\r\n46nineone\r\n7one2qthree\r\nnine2hjnfourninesixvblnqbgctwoeight\r\nqkggsnnthrxnrccbgs583\r\n351zkxqtmbd9sixthreegjjxt\r\nzrchlhmqcthreeninesmxz9\r\n219fivejrxgbjvvcxkjtwoseven\r\n8threebzzsxdx\r\nnine249ninefmlhj8rfour\r\n16zfljhfdcmkthree\r\n7sixjvdqgpvhmndpmhhzsphceight\r\ntwo2zjqc4nfd6732\r\n41threeseven1fourseven\r\n296fourgnq7three\r\ntbzdhbhs7ntshptcgrbkjspjdz\r\n55qcrmclmcck9\r\n25mhmtb3dscmjbhgv3four\r\nbjmhkxsffourhnxkxv1\r\njvntlbn5fivegjdcjl\r\n7gndbbbneight\r\n357623chktvtfzvf\r\n169plhsshseven\r\nnhgsrxcdfktpbzf9vpppxzkznine9\r\nxrdnlbmtdeightone3threeeighttwo\r\nbnnqzcfoneeight2hhdfkrrqzt\r\n342tlmjgtfcnine\r\n47rvtfqlzgmjlqbqthree\r\n7gnmxplrjbvfour6\r\nmcgbldbhlh1eightnine\r\ntwo9eightxnpdj61kzcdpnpnpfgsdrbcflh\r\n6541fourpkdplksnkpvkjxpdnvfttlfdflz\r\nkfour7\r\nx4tpbnnvnjlseven\r\n55nineninesevenzttsztwo9nlcqjq\r\n1drhjrzsbvpl\r\nmpknzhj9vmqckrpznqthreesj9\r\n211zqgpdlmpn\r\n4jxzrztg5onehnzvdbtcqdtsnkqtdvsd1fournine\r\nbvcrcz5four4\r\n4nineninecfhgtdphone9\r\nzbkjgbshqqkrcb3qmtfmdrdcckcsxshjb2\r\n1eightrblhbhljvkpshmrxc5\r\nhjcrrdsvnbqktxrgmq9nqgcztbv\r\n6lzsixl5one\r\ntwofivesevenfivesixonenine5seven\r\nfourmldkgnzb8djlsdmjnzxbmmvpf59seven\r\n8hnfkknnsrhm\r\nthree2krtqmmxqzs4jbrnrtrxzxsllblbkjmthcrlxxkdlh\r\nmglfmvvnthreefour1\r\nonehxz4fourhqcfvdlhg\r\nzrzqdgs5jsttkrone\r\nsevenrdmhnldsmdnineqfrgjhmhnnqkztxzm7\r\n63seven\r\n2seven3mrsltqb17\r\nfdbtvthmmrb5gbxvcmtwosixt5five\r\neightlzglvxfone5five7dlqpmseven5\r\ndmzdkbfive98onefivehhbljrnz\r\neight8ninefour\r\n24nvmftwofive\r\nseven3onefourrmgkxtcsfour\r\nfgpxmqqsfdrk8eight8zhcrzvrzmdxbbfive\r\neightonetwo7ninesjsrlr\r\nrrkrrtnkq941sixone\r\nthreeffspgv3eightfivesix5\r\nlthnrlgfcnine2scdcvnineseven\r\nsx86\r\ncxklrckbz5lsqq28\r\n5seven298\r\n933five5cmddfj46\r\nhrhhs76343\r\none3two4fourst4three\r\nnine3three\r\ndhtscvgm9foureight81vp\r\nbtpeightpzbtphdlcm8fiverknbrhthreelxndqcv\r\none96six45tm\r\nfourninetkdrvnbznnine22\r\nvxeightwothree5cd3jcnine\r\nseven5one4one7ninefive3\r\nnflkr2dlmtsrkrgkfvsixxvznjbvz3btxkhhqcc\r\neightrtz6jslqxsixoneeightnine\r\nxmvxn5\r\ntgnlrmjtkjdpbnpmsixbxfnl7sixone\r\nhtwonezcshpqgsix73qlgdqnkjskjthree\r\nnrlkxq6fnfourseven\r\nzmrlngjdhc41four4fourptrhddthreenhzv\r\nn9twogdrzkcsbk8hph6\r\n436sevens7cnkrrk\r\n6qkdvkhtwo\r\nmztkszm39\r\nfourtwo4mqhjkkdzgffhqfktwonine\r\nhbthree2hvpbznlgrxfgkthfour8\r\n34prfzlx4three\r\n29zzfdvghll9three6\r\ntwo83\r\none982\r\n36hhgdf7\r\nseven6ninednnine9mbtzfm1\r\none38\r\nseventhree5lsjxknqtdsbtxrkone\r\neightmfctkbc9jlxgdnchlq9one8nine\r\np371b\r\n9ninejszqsnpkfbthree1h5xscpfzvl\r\nthree9ljd\r\nfbbv9\r\nfive582\r\n58dctdbhbninesixczhd\r\nqp4\r\n6pfqdeight\r\n3onethreekqnnlt\r\nm4fgbmdtwo3\r\ntwodkrmtqs4\r\n9three6\r\nsix1798nineeightsqpvpsmcbmh\r\n9qxxmrmbnine3fivefourfive3four\r\none7sevenone78ninetwozqps\r\n973keight9seventwo\r\nkeightwothreethreeh6threeeightlnqdzhlt\r\nfive94\r\nmqlltnfive8eighttwoqhztggvqqkcxgvgmch\r\n2kpnsevenfive6\r\ngtmszpsjmggr3\r\npm126one3\r\nrvcqbtz9zjtndbxlrdcxzf3\r\nmkninekhmtxzbjpd8threeeight7eight\r\n5274xm636\r\nbleightfive9vdddzjdntthreerxtvdslrvbcvf\r\n9eight4sixdqzrltgpzlpxtcrzxbhmsmdtwothree\r\ncpneightwofive3fourtwo\r\none61threejxbjvsltxzpntpv\r\n19581\r\nsix2qllhlxhr1foursixz8\r\n6278teight3three\r\n8gstxqdngxzlxvnvphlsznr3kknftvzxcqqbrfteightthree\r\n4jlzjvjfltwo7pv\r\n7dvt\r\nblhsm4xcrbrf68ninezvhhtqgphnzxlhl\r\n9dvjvfourtcthree\r\nonethreenfkgrvsevenkczctlgkt7";

        private static readonly TrieNode forwardTrie;
        private static readonly TrieNode backwardTrie;

        static Day1()
        {
            var fowardWordValues = new (string, int)[]
            {
                ("one", 1),
                ("two", 2),
                ("three", 3),
                ("four", 4),
                ("five", 5),
                ("six", 6),
                ("seven", 7),
                ("eight", 8),
                ("nine", 9),
            };

            var backwardWordValues = new (string, int)[fowardWordValues.Length];
            for (int i = 0; i < backwardWordValues.Length; i++)
            {
                backwardWordValues[i] = (string.Join(string.Empty, fowardWordValues[i].Item1.Reverse()), fowardWordValues[i].Item2);
            }

            forwardTrie = TrieNode.BuildFrom(fowardWordValues);
            backwardTrie = TrieNode.BuildFrom(backwardWordValues);
        }

        public static int SolvePart1(bool runTestCase = true)
        {
            var calibrationDocument = runTestCase ? TestCaseInputPart1 : Input;

            int sum = 0;
            foreach (var line in calibrationDocument.Split("\r\n"))
            {
                int firstDigit = 0, lastDigit = 0;

                for (int idx = 0; idx < line.Length; idx++)
                {
                    if (char.IsDigit(line[idx]))
                    {
                        firstDigit = ParseIndexFromNumber(line[idx]);
                        break;
                    }
                }
                
                for (int idx = line.Length - 1; idx >= 0; idx--)
                {
                    if (char.IsDigit(line[idx]))
                    {
                        lastDigit = ParseIndexFromNumber(line[idx]);
                        break;
                    }
                }

                sum += (firstDigit * 10 + lastDigit);
            }

            return sum;
        }


        public static int SolvePart2(bool runTestCase = true)
        {
            var calibrationDocument = runTestCase ? TestCaseInputPart2 : Input;
            int sum = 0;

            foreach (var line in calibrationDocument.Split("\r\n"))
            {
                int firstDigit = 0, lastDigit = 0;

                var foundLeftDigit = false;
                for (int i = 0; !foundLeftDigit && i < line.Length; i++)
                {
                    if (char.IsDigit(line[i]))
                    {
                        firstDigit = ParseIndexFromNumber(line[i]);
                        break;
                    }

                    var node = forwardTrie;
                    int j = i;
                    while (j < line.Length && char.IsLetter(line[j]) && (node = node.Children[ParseIndexFromLetter(line[j])]) != null)
                    {
                        if (node.CompletedWord)
                        {
                            firstDigit = node.Value;
                            foundLeftDigit = true;
                            break;
                        }

                        j++;
                    }
                }

                var foundRightDigit = false;
                for (int i = line.Length - 1; !foundRightDigit && i >= 0; i--)
                {
                    if (char.IsDigit(line[i]))
                    {
                        lastDigit = ParseIndexFromNumber(line[i]);
                        break;
                    }

                    var node = backwardTrie;
                    int j = i;
                    while (j >= 0 && char.IsLetter(line[j]) && (node = node.Children[ParseIndexFromLetter(line[j])]) != null)
                    {
                        if (node.CompletedWord)
                        {
                            lastDigit = node.Value;
                            foundRightDigit = true;
                            break;
                        }

                        j--;
                    }
                }

                sum += (firstDigit * 10 + lastDigit);
            }

            return sum;
        }

        public static int ParseIndexFromLetter(char ch)
        {
            return (int)ch - (int)'a';
        }

        public static int ParseIndexFromNumber(char ch)
        {
            return (int)ch - (int)'0'; ;
        }
    }

    class TrieNode
    {
        public bool CompletedWord;
        public int Value;
        public TrieNode[] Children;

        private TrieNode()
        {
            Children = new TrieNode[26]; // English alphabet
        }

        public static TrieNode BuildFrom((string, int)[] words)
        {
            var root = new TrieNode();
            foreach (var wordVal in words)
            {
                var node = root;
                var word = wordVal.Item1;

                for (int i = 0; i < word.Length; i++)
                {
                    var charIdx = Day1.ParseIndexFromLetter(word[i]);
                    if (node.Children[charIdx] == null)
                        node.Children[charIdx] = new TrieNode();
                    
                    node = node.Children[charIdx];
                    if (i == word.Length - 1)
                    {
                        node.CompletedWord = true;
                        node.Value = wordVal.Item2;
                    }
                }
            }

            return root;
        }
    }
}
