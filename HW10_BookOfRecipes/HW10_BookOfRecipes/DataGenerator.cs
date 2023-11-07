using HW10_BookOfRecipes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HW10_BookOfRecipes
{
    public class DataGenerator
    {
        public static List<M_Recipe> recipes = new List<M_Recipe> { 
        
            new M_Recipe
            {
                Title = "ПИРОЖКИ С ВЕТЧИНОЙ И СЫРОМ",
                Description = "Мягкие, очень сытные и вкусные. На любой случай. Пирожки с ветчиной и сыром из дрожжевого теста понравятся взрослым и особенно порадуют детей. Чтобы ускорить процесс приготовления, можно взять готовое свежее или замороженное дрожжевое тесто.Отличная выпечка на каждый день к любым напиткам.",
                ImageSource = "/Resource/Images/1.jpg",
                Ingredients = new List<M_Ingridients>
                {
                    new M_Ingridients{ Name = "Яичные желтки", Count = "1 шт." },
                    new M_Ingridients{ Name = "Пшеничная мука", Count = "500 гр." },
                    new M_Ingridients{ Name = "Майонез", Count = "150 гр." },
                    new M_Ingridients{ Name = "Молоко", Count = "140 мл." },
                    new M_Ingridients{ Name = "Сухие дрожжи", Count = "8 гр." },
                    new M_Ingridients{ Name = "Сахар", Count = "0.5 ст.л." },
                    new M_Ingridients{ Name = "Соль", Count = "1 чн.л." },
                    new M_Ingridients{ Name = "Ветчина", Count = "300 гр." },
                    new M_Ingridients{ Name = "Твёрдый сыр", Count = "100 гр." },
                    new M_Ingridients{ Name = "Яйца", Count = "1 шт." },
                    new M_Ingridients{ Name = "Перец черный молотый", Count = "по вкусу." },
                    new M_Ingridients{ Name = "Соль", Count = "по вкусу." },
                },
                Instructions = new List<M_Instruction> { 
                    new M_Instruction { Title = "ШАГ 1:", Description = "Как сделать дрожжевые пирожки с ветчиной и сыром в духовке? Подготовьте необходимые ингредиенты для теста. Перед тем, как покупать дрожжи, почитайте инструкцию. Так как есть быстродействующие дрожжи, которые смешиваются с мукой сразу. В этом же рецепте понадобятся дрожжи, которые разводятся жидкостью — в данном случае молоком. Муку берите высшего сорта. О видах дрожжей и способах их замены в рецептах читайте в статье под шагами." },
                    new M_Instruction { Title = "ШАГ 2:", Description = "В теплом молоке, нагретом до температуры 37-40°С, растворите сахар, соль и дрожжи. Все перемешайте. Оставьте в теплом месте на 15 минут. На поверхности должна получиться пенная шапочка. Это значит, что дрожжи активны и можно замешивать тесто дальше. Если этого не произошло, выпечка не получится." },
                    new M_Instruction { Title = "ШАГ 3:", Description = "Добавьте майонез и перемешайте венчиком до однородности." },
                    new M_Instruction { Title = "ШАГ 4:", Description = "Частями всыпьте просеянную муку и замесите мягкое однородное тесто, при необходимости добавляя еще немного муки. О муке и её свойствах подробнее можно прочитать в отдельной статье, ссылка в конце рецепта." },
                    new M_Instruction { Title = "ШАГ 5:", Description = "Учтите, что муки может понадобится больше или меньше. Тесто само возьмет, сколько ему нужно. Если тесто все еще липнет, а муки требуется еще больше, чем по рецепту, лучше не забивайте тесто мукой, иначе в готовом виде тесто получится слишком плотное и невкусное. Лучше посыпьте мукой скалку и стол при раскатке." },
                    new M_Instruction { Title = "ШАГ 6:", Description = "Выложите тесто в миску, накройте полотенцем и оставьте в тепле для подъема на 1 час." },
                    new M_Instruction { Title = "ШАГ 7:", Description = "Теперь подготовьте ингредиенты для начинки. Для смазывания заготовок возьмите желток. Включите духовку на 180 градусов." },
                    new M_Instruction { Title = "ШАГ 8:", Description = "Ветчину нарежьте кружочками толщиной 0,5-1 см." },
                    new M_Instruction { Title = "ШАГ 9:", Description = "Сыр натрите на крупной терке. Сыр подойдет любой, начиная от обычного Российского и заканчивая сулугуни. Главное, чтобы сыр был вкусный, без красителей и заменителей молочных жиров и хорошо плавился." },
                    new M_Instruction { Title = "ШАГ 10:", Description = "В миске соедините тертый сыр, яйцо, соль и перец и перемешайте." },
                    new M_Instruction { Title = "ШАГ 11:", Description = "Тесто обомните и разделите на две равные части. Первую часть теста раскатайте в тонкий прямоугольный пласт. Стаканом (он должен быть больше диаметром, чем кружочки ветчины) слегка наметьте на тесте кружочки. В центр намеченных кружков выложите по ломтику ветчины. На ветчину горкой выложите сырную начинку." },
                    new M_Instruction { Title = "ШАГ 12:", Description = "Второй пласт теста раскатайте в прямоугольник большего размера и накройте им начинку." },
                    new M_Instruction { Title = "ШАГ 13:", Description = "Тем же стаканом вырежьте заготовки. Обрезки теста снова раскатайте и сделайте заготовки." },
                    new M_Instruction { Title = "ШАГ 14:", Description = "Выложите заготовки на застеленный пергаментом противень и смажьте желтком. Чем еще можно смазать выпечку читайте в статье в конце рецепта. Выпекайте в заранее разогретой до 180℃ около 25 минут до румяной корочки на режиме «верх+низ» без конвекции. Узнать об особенностях работы духовок, а также об особенностях различных видов пергамента можно, прочитав отдельную статью, ссылка в конце рецепта." },
                    new M_Instruction { Title = "ШАГ 15:", Description = "Готовые пирожки с ветчиной сразу же подайте к столу. Приятного аппетита!" },
                }
            },

            new M_Recipe
            {
                Title = "ЗАЛИВНОЙ ПИРОГ С КАПУСТОЙ НА МАЙОНЕЗЕ",
                Description = "Так вкусно и так просто - исчезнет за одну минуту! Приготовить заливной пирог с капустой на майонезе очень легко. Для него вам понадобится минимум продуктов, которые всегда есть под рукой. Этот пирог выручит, когда нет времени на готовку.",
                ImageSource = "/Resource/Images/2.jpg",
                Ingredients = new List<M_Ingridients>
                {
                    new M_Ingridients{ Name = "Пшеничная мука", Count = "78 гр." },
                    new M_Ingridients{ Name = "Яйца", Count = "2 шт." },
                    new M_Ingridients{ Name = "Майонез", Count = "78 гр." },
                    new M_Ingridients{ Name = "Разрыхлитель", Count = "3 гр." },
                    new M_Ingridients{ Name = "Соль", Count = "по вкусу" },
                    new M_Ingridients{ Name = "Капуста", Count = "200 гр." },
                    new M_Ingridients{ Name = "Лук", Count = "1 шт." },
                    new M_Ingridients{ Name = "Морковь", Count = "1 шт." },
                    new M_Ingridients{ Name = "Растительное масло", Count = "40 гр." },
                    new M_Ingridients{ Name = "Вода", Count = "50 мл." },
                },
                Instructions = new List<M_Instruction> {
                    new M_Instruction { Title = "ШАГ 1:", Description = "Как испечь простой заливной пирог с капустой на майонезе в духовке? Подготовьте продукты. В первую очередь для начинки. Капусту возьмите белокочанную, сочную, вкусную. Подойдет как ранняя, весенняя, так и поздняя, осенних сортов. Морковь в начинку вы можете не добавлять, а вот лук положите обязательно — он обогатит ее вкус. Также можно добавить любую зелень по вкусу. Масло возьмите рафинированное, без запаха." },
                    new M_Instruction { Title = "ШАГ 2:", Description = "Лук очистите и нарежьте мелкими кубиками." },
                    new M_Instruction { Title = "ШАГ 3:", Description = "Морковь очистите и натрите на крупной терке." },
                    new M_Instruction { Title = "ШАГ 4:", Description = "С кочана снимите верхние листья, отрежьте нужное количество. Нашинкуйте капусту тонкой соломкой." },
                    new M_Instruction { Title = "ШАГ 5:", Description = "Разогрейте на среднем огне сковороду, налейте на нее растительное масло для жарки. Выложите на нее лук. Обжарьте его, помешивая, пару минут, до прозрачности. Добавьте к луку морковь. Жарьте овощи еще несколько минут. О том, как подобрать идеальную сковороду, а также как правильно выбрать масло для жарки, читайте в отдельных статьях, ссылки в конце рецепта." },
                    new M_Instruction { Title = "ШАГ 6:", Description = "Добавьте к овощам нашинкованную капусту. Посолите ее по вкусу. перемешайте. Влейте небольшое количество воды, накройте сковороду крышкой, огонь убавьте. Тушите капусту 10 минут, затем перемешайте ее и продолжайте тушение еще 10 минут. Капуста должна стать мягкой, а вода вся выпариться. Если она молодая, то время тушения уменьшите." },
                    new M_Instruction { Title = "ШАГ 7:", Description = "Приготовьте тесто. Подготовьте продукты для нее. Майонез возьмите хорошего качества, вкусный, от этого будет зависеть вкус блюда. Майонез можно сделать самостоятельно. Рецепты домашнего майонеза вы найдёте после последнего шага. Количество муки дано примерное, будете смотреть по тесту. Из стольких ингредиентов теста получается не очень много, если вы любите пироги с толстым слоем теста, то увеличьте их количество. Включите духовку на 180 градусов." },
                    new M_Instruction { Title = "ШАГ 8:", Description = "Яйца вбейте в миску, добавьте к ним майонез. Венчиком взбейте все до однородности." },
                    new M_Instruction { Title = "ШАГ 9:", Description = "В муку всыпьте разрыхлитель, перемешайте. Начните порциями добавлять муку к яично-майонезной смеси, перемешивая тесто после каждого добавления. Когда тесто станет как густая сметана, добавлять перестаньте. У меня ушло меньше муки. О свойствах муки и всех тонкостях использования разрыхлителя читайте в отдельных статьях по ссылкам в конце рецепта." },
                    new M_Instruction { Title = "ШАГ 10:", Description = "Возьмите форму для выпечки, у меня круглая, диаметром 20см. Смажьте дно и стенки кусочком сливочного масла. Вылейте в нее половину теста, лопаткой распределите его равномерно. Выложите на тесто обжаренную начинку. По краям оставьте небольшое \"кольцо\" теста без начинки, чтобы при выпечке она оказалась внутри пирога. О том, как выбрать форму для запекания, читайте в отдельной статье по ссылке в конце рецепта." },
                    new M_Instruction { Title = "ШАГ 11:", Description = "Залейте начинку остатками теста. Распределите его равномерно. Можете при желании посыпать его кунжутом или натертым твердым сыром." },
                    new M_Instruction { Title = "ШАГ 12:", Description = "Выпекайте пирог в духовке, предварительно разогретой до 180°С. Сколько выпекать пирог с капустой? Потребуется около 30 минут. Точное время будет зависеть от особенностей вашей духовки и размера пирога. Ориентируйтесь на внешний вид — пирог станет румяным. Узнать об особенностях работы духовок можно, прочитав отдельную статью, ссылка в конце рецепта." },
                    new M_Instruction { Title = "ШАГ 13:", Description = "Подавайте пирог к столу. Приятного аппетита!" },
                }
            },
            new M_Recipe
            {
                Title = "КУТАБЫ С СЫРОМ НА СКОВОРОДЕ",
                Description = "Потрясающе аппетитные, с сочной начинки. Язык проглотишь! Кутабы с сыром на сковороде понравятся всем любителям подобной выпечки. Тесто получается очень эластичным, с ним приятно работать. Для начинки можно использовать любой сыр или сочетания сыров. Замечательная закуска к бокалу белого вина.",
                ImageSource = "/Resource/Images/3.jpg",
                Ingredients = new List<M_Ingridients>
                {
                    new M_Ingridients{ Name = "Пшеничная мука", Count = "300 гр." },
                    new M_Ingridients{ Name = "Вода", Count = "150 мл." },
                    new M_Ingridients{ Name = "Растительное масло", Count = " гр." },
                    new M_Ingridients{ Name = "Соль", Count = "1 чн.ложка" },
                    new M_Ingridients{ Name = "Помидоры", Count = "200 гр." },
                    new M_Ingridients{ Name = "Твёрдый сыр", Count = "150 гр." },
                    new M_Ingridients{ Name = "Укроп", Count = "50 гр." },
                    new M_Ingridients{ Name = "Перец черный молотый", Count = "по вкусу." },
                },
                Instructions = new List<M_Instruction> {
                    new M_Instruction { Title = "ШАГ 1:", Description = "Как сделать кутабы с зеленью и сыром на сковороде? Очень просто и быстро. Подготовьте необходимые ингредиенты. Начать лучше с приготовления теста. Муку берите высшего сорта. Растительное масло подойдет любое. У меня подсолнечное рафинированное." },
                    new M_Instruction { Title = "ШАГ 2:", Description = "Муку просейте в миску, так она насытится кислородом, и тесто получится нежнее. Всыпьте соль и перемешайте." },
                    new M_Instruction { Title = "ШАГ 3:", Description = "Сделайте в муке углубление. Влейте в муку воду и растительное масло. Быстро замесите мягкое пышное эластичное однородное тесто, при необходимости добавляя еще муки." },
                    new M_Instruction { Title = "ШАГ 4:", Description = "Учтите, что муки может понадобится больше или меньше. Но не торопитесь забивать все тесто мукой, пытаясь избавиться от липкости. Иначе тесто станет резиновым и неподатливым. Лучше посыпьте при раскатке стол и скалку мукой. Тесто само возьмет, сколько ему нужно. Дополнительные сведения о муке читайте в статье под шагами." },
                    new M_Instruction { Title = "ШАГ 5:", Description = "Скатайте тесто в шар, заверните в пищевую пленку или пакет и оставьте на 10-15 минут отдохнуть. Можете также замешивать тесто на горячей воде. Я делала и так, и так. На холодной воде тесто получается более мягкое и пластичное." },
                    new M_Instruction { Title = "ШАГ 6:", Description = "Тем временем подготовьте начинку. Специи можете дополнять по своему вкусу." },
                    new M_Instruction { Title = "ШАГ 7:", Description = "Сыр натрите на крупной терке. Для этого рецепта можно использовать рассольную и нерассольную моцареллу, сулугуни, а также любой сыр по вашему вкусу, который хорошо плавится. Как заменять разные виды сыров читайте в статье в конце рецепта." },
                    new M_Instruction { Title = "ШАГ 8:", Description = "Помидоры вымойте, обсушите и нарежьте небольшими кубиками." },
                    new M_Instruction { Title = "ШАГ 9:", Description = "Укроп вымойте, обсушите и мелко порубите. По желанию можете заменить или дополнить другой зеленью, например, петрушкой, кинзой, зеленым луком или использовать смесь разных трав." },
                    new M_Instruction { Title = "ШАГ 10:", Description = "В миске соедините помидоры, тертый сыр и зелень. Начинку слегка посолите, поперчите и перемешайте." },
                    new M_Instruction { Title = "ШАГ 11:", Description = "Тесто разделите на 5-6 равных частей." },
                    new M_Instruction { Title = "ШАГ 12:", Description = "Каждую часть раскатайте в тонкий круг. На одну сторону круга выложите 2-3 ст. л. начинки." },
                    new M_Instruction { Title = "ШАГ 13:", Description = "Накройте второй частью теста. Края защипайте." },
                    new M_Instruction { Title = "ШАГ 14:", Description = "Заготовки обжарьте на сухой сковороде на среднем огне с двух сторон до появления золотистых пятнышек. Как выбрать сковороду читайте в статьях на эти темы. Ссылка в конце рецепта." },
                    new M_Instruction { Title = "ШАГ 15:", Description = "Горячие кутабы с зеленью и сыром смажьте сливочным маслом и сразу подайте к столу. Приятного аппетита!" },
                }
            },
            new M_Recipe
            {
                Title = "ПРОСТОЙ САЛАТ С ТОФУ И ПОМИДОРАМИ",
                Description = "Постный, сытный, изумительно вкусный - на любой случай! Простой салат с тофу и помидорами привлекателен низким содержанием углеводов. Он подойдет не только тем, кто следит за питанием и фигурой, но и постящимся. Обжарка сыра в специях придает блюду пикантную изюминку.",
                ImageSource = "/Resource/Images/4.jpg",
                Ingredients = new List<M_Ingridients>
                {
                    new M_Ingridients{ Name = "Тофу", Count = "200 гр." },
                    new M_Ingridients{ Name = "Помидоры", Count = "200  гр." },
                    new M_Ingridients{ Name = "Авокадо", Count = "1 шт." },
                    new M_Ingridients{ Name = "Лук", Count = "1 шт." },
                    new M_Ingridients{ Name = "Растительное масло", Count = "1 ст.л." },
                    new M_Ingridients{ Name = "Паприка (копченая)", Count = "1 чн.л" },
                    new M_Ingridients{ Name = "Перец черный молотый", Count = "по вкусу" },
                    new M_Ingridients{ Name = "Лимонный сок", Count = "1 чн.л." },
                    new M_Ingridients{ Name = "Чеснок", Count = " 1 зубч." },
                },
                Instructions = new List<M_Instruction> {
                    new M_Instruction { Title = "ШАГ 1:", Description = "Как сделать простой салат с сыром тофу и помидорами? Для начала подготовьте ингредиенты для заправки. Растительное масло подойдет любое, желательно душистое, нерафинированное. У меня оливковое. Свежий чеснок можете заменить 1/2 ч. л. сухого. По желанию можете добавить в заправку немного жидкого меда." },
                    new M_Instruction { Title = "ШАГ 2:", Description = "В мисочке соедините оливковое масло, лимонный сок, пропущенный через пресс зубчик чеснока и соль. Взбейте всё до однородности." },
                    new M_Instruction { Title = "ШАГ 3:", Description = "Теперь подготовьте продукты для салата. Помидоры можете использовать любые - обычные или черри. Овощную часть и специи можете дополнять или заменять по своему вкусу. Вместо тофу можете взять любой сыр по вашему вкусу и без обжарки, однако обратите внимание, что с другим видом сыра салат получится непостный." },
                    new M_Instruction { Title = "ШАГ 4:", Description = "Тофу нарежьте средними кубиками." },
                    new M_Instruction { Title = "ШАГ 5:", Description = "Выложите соевый сыр в пакет, всыпьте копченую паприку, черный молотый перец и соль. Завяжите пакет и потрясите, чтобы специи равномерно распределились по сыру." },
                    new M_Instruction { Title = "ШАГ 6:", Description = "В сковороде на среднем огне разогрейте растительное масло и, помешивая, обжарьте тофу до золотистого цвета. О том, как подобрать идеальную сковороду, а также как правильно выбрать масло для жарки, читайте в отдельных статьях, ссылки в конце рецепта." },
                    new M_Instruction { Title = "ШАГ 7:", Description = "Помидоры вымойте, обсушите и нарежьте дольками. Если у вас помидоры черри, то нарежьте их половинками. Помидоры нужны сочные, но плотные. Мягкие плоды плохо держат форму, в процессе нарезки и приготовления они расползутся в бесформенную массу и испортят внешний вид блюда." },
                    new M_Instruction { Title = "ШАГ 8:", Description = "Красную луковицу очистите и нарежьте тонкими кольцами или полукольцами." },
                    new M_Instruction { Title = "ШАГ 9:", Description = "Авокадо разрежьте пополам, удалите косточку. Каждую половинку очистите от кожуры и нарежьте небольшими кусочками. Важно очищать авокадо именно в такой последовательности. Ведь авокадо содержит эфирные масла и после снятия кожуры плод становится скользким. При разрезании его пополам можете порезаться." },
                    new M_Instruction { Title = "ШАГ 10:", Description = "В миске соедините помидоры, авокадо, красный лук и тофу. Полейте салат заправкой и перемешайте." },
                    new M_Instruction { Title = "ШАГ 11:", Description = "Салат украсьте свежей зеленью и сразу подайте к столу. Приятного аппетита!" },
                }
            },
            //new M_Recipe
            //{
            //    Title = "",
            //    Description = "",
            //    ImageSource = "/Resource/Images/2.jpg",
            //    Ingredients = new List<M_Ingridients>
            //    {
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //    },
            //    Instructions = new List<M_Instruction> {
            //        new M_Instruction { Title = "ШАГ 1:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 2:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 3:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 4:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 5:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 6:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 7:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 8:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 9:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 10:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 11:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 12:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 13:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 14:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 15:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 16:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 17:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 18:", Description = "" },
            //    }
            //},
            //new M_Recipe
            //{
            //    Title = "",
            //    Description = "",
            //    ImageSource = "/Resource/Images/2.jpg",
            //    Ingredients = new List<M_Ingridients>
            //    {
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //    },
            //    Instructions = new List<M_Instruction> {
            //        new M_Instruction { Title = "ШАГ 1:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 2:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 3:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 4:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 5:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 6:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 7:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 8:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 9:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 10:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 11:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 12:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 13:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 14:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 15:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 16:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 17:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 18:", Description = "" },
            //    }
            //},
            //new M_Recipe
            //{
            //    Title = "",
            //    Description = "",
            //    ImageSource = "/Resource/Images/2.jpg",
            //    Ingredients = new List<M_Ingridients>
            //    {
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //        new M_Ingridients{ Name = "", Count = " гр." },
            //    },
            //    Instructions = new List<M_Instruction> {
            //        new M_Instruction { Title = "ШАГ 1:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 2:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 3:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 4:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 5:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 6:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 7:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 8:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 9:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 10:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 11:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 12:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 13:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 14:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 15:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 16:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 17:", Description = "" },
            //        new M_Instruction { Title = "ШАГ 18:", Description = "" },
            //    }
            //},



        };

        public static List<M_Recipe> GetM_Recipes()
        {
            return recipes;
        }
    }
}
