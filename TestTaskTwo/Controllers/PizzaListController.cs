using DataBaseContext.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TestTaskTwo.Models;

namespace TestTaskTwo.Controllers
{
    public class PizzaListController : Controller
    {
        private readonly string _url = "https://cagliari-pizza.ru/images/dishes/";
        private readonly List<PizzaDataModel> _list;
        private readonly IDataBaseContext _context;

        public PizzaListController()
        {
            _list = new() 
            {
                new()
                {
                    Image = _url + "buritto.jpg",
                    Name = "Буритто",
                    Description = "Соус \"Томатный острый\", Сыр моцарелла, Куриная грудка, Кукуруза, Фасоль консервированная, Соус сырный \"Пармеджано\",",
                    Ingredients = new string[] { "Перец болгарский", "Лук маринованный" },
                    SelectedSize = 1,
                    AvailableSizes = new bool[] { true, true, false },
                    SelectedThiknes = 1,
                    AvailableThickness = new bool[] { true, true },
                    Price = 690,
                    Mass = 1440,
                    IsHalf = true,
                    IsAvailableThickness = false
                },
                new()
                {
                    Image = _url + "kolizey.jpg",
                    Name = "Колизей",
                    Description = "Соус \"Горчичный\", Сыр моцарелла, Куриный рулет, Колбаски охотничьи, Соус \"Кисло - сладкий\",",
                    Ingredients = new string[] { "Томаты свежие", "Лук маринованный" },
                    SelectedSize = 1,
                    AvailableSizes = new bool[] { true, true, false },
                    SelectedThiknes = 1,
                    AvailableThickness = new bool[] { true, true },
                    Price = 690,
                    Mass = 1440,
                    IsHalf = true,
                    IsAvailableThickness = false
                },
                new()
                {
                    Image = _url + "miliciano.jpg",
                    Name = "Милициано",
                    Description = "Соус \"Кальяри\", Куриная грудка, Овощная смесь, Сыр с голубой плесенью",
                    Ingredients = new string[] { },
                    SelectedSize = 1,
                    AvailableSizes = new bool[] { true, true, false },
                    SelectedThiknes = 1,
                    AvailableThickness = new bool[] { true, true },
                    Price = 690,
                    Mass = 1440,
                    IsHalf = true,
                    IsAvailableThickness = false
                },
                new()
                {
                    Image = _url + "peperoni_novinka.jpg",
                    Name = "Новинка",
                    Description = "Сыр моцарелла x2, Соус \"1000 островов\", Пепперони,",
                    Ingredients = new string[] { "Томаты свежие" },
                    SelectedSize = 1,
                    AvailableSizes = new bool[] { true, true, false },
                    SelectedThiknes = 1,
                    AvailableThickness = new bool[] { true, true },
                    Price = 690,
                    Mass = 1440,
                    IsHalf = true,
                    IsAvailableThickness = false
                },
                new()
                {
                    Image = _url + "novinka.jpg",
                    Name = "Capriccio",
                    Description = "Сыр моцарелла, Соус \"Барбекю\", Соус \"Кальяри\", Пепперони, Овощи гриль, Бекон, Ветчина, Орегано,",
                    Ingredients = new string[] { "Томаты черри", "Шампиньоны" },
                    SelectedSize = 1,
                    AvailableSizes = new bool[] { true, true, false },
                    SelectedThiknes = 1,
                    AvailableThickness = new bool[] { true, true },
                    Price = 690,
                    Mass = 1440,
                    IsHalf = true,
                    IsAvailableThickness = false
                },
                new()
                {
                    Image = _url + "xxxl.jpg",
                    Name = "XXXL",
                    Description = "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные, ",
                    Ingredients = new string[] { "Томаты черри", "Маслины", "Лук маринованный" },
                    SelectedSize = 1,
                    AvailableSizes = new bool[] { true, true, false },
                    SelectedThiknes = 1,
                    AvailableThickness = new bool[] { true, true },
                    Price = 690,
                    Mass = 1440,
                    IsHalf = true,
                    IsAvailableThickness = false
                },
                new()
                {
                    Image = _url + "4_vkusa.jpg",
                    Name = "4 вкуса",
                    Description = "Соус \"1000 островов\", Сыр моцарелла, Рулет куриный, Ветчина, Пепперони, Сыр пармезан, Орегано, ",
                    Ingredients = new string[] { "Шимпиньоны", "Томаты свежие", "Маслины/оливки" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 420,
                    Mass = 540,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "amazonka.jpg",
                    Name = "Амазонка",
                    Description = "Соус \"Томатный\", Сыр моцарелла, Куриная грудка, Брокколи, Огурцы маринованные, Орегано,",
                    Ingredients = new string[] { "Шимпиньоны", "Томаты черри", "Маслины", "Лук маринованный" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 420,
                    Mass = 600,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "bananzza.jpg",
                    Name = "БананZZа",
                    Description = "Бананы, Соус \"Гавайский\", Сыр моцарелла, Ананас, Шоколад молочный, Кокос/миндаль, Орегано",
                    Ingredients = new string[] { },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 390,
                    Mass = 520,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "barbeq.jpg",
                    Name = "Барбекю",
                    Description = "Соус \"Томатный\", Сыр моцарелла, Ветчина, Бекон, Пепперони, Соус \"Барбекю\", Орегано,",
                    Ingredients = new string[] { "Томаты", "Перец болгарский", "Лук маринованный" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 420,
                    Mass = 590,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "hawai.jpg",
                    Name = "Гавайская",
                    Description = "Ветчина, Соус \"Гавайский\", Сыр моцарелла, Ананас, Орегано,",
                    Ingredients = new string[] { "Перец болгарский" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 420,
                    Mass = 550,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "hawai_premium.jpg",
                    Name = "Гавайская Premium",
                    Description = "Соус \"Гавайский\", Сыр моцарелла, Ананас, Ветчина, Куриный рулет, Кукуруза, Орегано,",
                    Ingredients = new string[] { "Перец болгарский" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, true },
                    Price = 440,
                    Mass = 590,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "grek.jpg",
                    Name = "Греческая",
                    Description = "Соус \"Кальяри\", Сыр моцарелла, Сливочный сыр, Брокколи, Орегано,",
                    Ingredients = new string[] { "Томаты черри", "Перец болгарский", "Маслины" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 435,
                    Mass = 570,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "gribnaya.jpg",
                    Name = "Грибная",
                    Description = "Соус \"Кальяри\", Сыр моцарелла, Сливочный сыр, Брокколи, Орегано,",
                    Ingredients = new string[] { "Шампиньоны", "Лук маринованный" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 430,
                    Mass = 550,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "dereven.jpg",
                    Name = "Деревенская",
                    Description = "Соус \"1000 островов\", Сыр моцарелла, Ветчина, Сервелат, Огурцы маринованные, Опята маринованные, Укроп, Орегано,",
                    Ingredients = new string[] { "Лук маринованный" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 430,
                    Mass = 560,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "dom.jpg",
                    Name = "Домашняя",
                    Description = "Соус \"Томатный\", Сыр моцарелла, Ветчина, Сервелат, Орегано,",
                    Ingredients = new string[] { "Томаты", "Шампиньоны" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 415,
                    Mass = 510,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "bekon.jpg",
                    Name = "Дон бекон",
                    Description = "Бекон, Соус \"Кальяри\", Сыр моцарелла, Орегано,",
                    Ingredients = new string[] { "Томаты черри" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 410,
                    Mass = 550,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "diabolo.jpg",
                    Name = "Дьябло",
                    Description = "Соус \"Томатный\", Сыр моцарелла, Ветчина, Пепперони, Соус \"Кимчи\", Орегано, Халапеньо,",
                    Ingredients = new string[] { "Томаты" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 410,
                    Mass = 560,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "cagliari.jpg",
                    Name = "Кальяри",
                    Description = "Соус \"Кальяри\", Креветки тигровые, Куриная грудка, Сыр моцарелла, Ананас, Соус \"Унаги\", Кунжут, Орегано",
                    Ingredients = new string[] { },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 470,
                    Mass = 560,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "korol.jpg",
                    Name = "Королевская",
                    Description = "Соус \"Кальяри\", Сыр моцарелла, Бекон, Креветки тигровые, Сыр пармезан, Орегано,",
                    Ingredients = new string[] { "Томаты черри" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 410,
                    Mass = 585,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "krest.jpg",
                    Name = "Крестьянская",
                    Description = "Соус \"1000 островов\", Сыр моцарелла, Ветчина, Бекон, Укроп, Орегано,",
                    Ingredients = new string[] { "Томаты", "Шампиньоны", "Лук маринованный" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 490,
                    Mass = 520,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "lososio.jpg",
                    Name = "Лососио",
                    Description = "Соус \"Кальяри\", Сыр моцарелла, Лосось, Стружка тунца, Кунжут, Орегано",
                    Ingredients = new string[] { "Томаты" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 470,
                    Mass = 560,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "margarita.jpg",
                    Name = "Маргарита",
                    Description = "Соус \"Томатный\", Сыр моцарелла, Сливочный сыр, Орегано,",
                    Ingredients = new string[] { "Томаты черри" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 400,
                    Mass = 460,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "sea.jpg",
                    Name = "Морская",
                    Description = "Соус \"Кальяри\", Сыр моцарелла, Кальмар, Креветки тигровые, Мидии, Осьминог, Лимон, Укроп, Орегано,",
                    Ingredients = new string[] { "Лук маринованный", "Маслины" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 490,
                    Mass = 550,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "meat.jpg",
                    Name = "Мясная сборная",
                    Description = "Соус \"Барбекю\", Сыр моцарелла, Куриный рулет, Ветчина, Бекон, Сервелат, Орегано,",
                    Ingredients = new string[] { "Томаты", "Перец болгарский", "Лук маринованный", "Маслины" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 430,
                    Mass = 610,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "ohota.jpg",
                    Name = "Охотничья",
                    Description = "Соус \"1000 островов\", Сыр моцарелла, Сервелат, Бекон, Колбаски охотничьи, Сливочный сыр, Сыр пармезан, Орегано,",
                    Ingredients = new string[] { "Томаты черри", "Лук маринованный", "Маслины" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 440,
                    Mass = 560,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "peperoni.jpg",
                    Name = "Пепперони",
                    Description = "Соус \"Томатный\", Сыр моцарелла, Пепперони, Орегано",
                    Ingredients = new string[] { },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 390,
                    Mass = 410,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "pikantnaya.jpg",
                    Name = "Пикантная",
                    Description = "Соус \"Кальяри\", Ветчина, Орегано, Сливочный сыр, Сыр моцарелла, Сыр пармезан,",
                    Ingredients = new string[] { },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 440,
                    Mass = 510,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "pinokio.jpg",
                    Name = "Пиноккио",
                    Description = "Соус \"Гавайский\", Куриный рулет, Сыр моцарелла, Кукуруза, Орегано",
                    Ingredients = new string[] { },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 420,
                    Mass = 510,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "cezar.jpg",
                    Name = "Пицца-Cezar",
                    Description = "Ветчина, Куриная грудка, Соус \"Кальяри\", Сыр моцарелла, Сыр пармезан, Салат айсберг, Соус \"Спайси\", Орегано,",
                    Ingredients = new string[] { "Томаты черри" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 440,
                    Mass = 640,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "burger.jpg",
                    Name = "Пицца-бургер",
                    Description = "Соус \"Томатный\", Сыр моцарелла, Куриный рулет, Ветчина, Соус \"Бургер\", Сервелат, Кунжут, Орегано,",
                    Ingredients = new string[] { "Перец болгарский" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 430,
                    Mass = 570,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "sardin.jpg",
                    Name = "Сардиния",
                    Description = "Соус \"Кальяри\", Сыр моцарелла, Брокколи, Сливочный сыр, Креветки тигровые, Орегано,",
                    Ingredients = new string[] { "Томаты черри" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 480,
                    Mass = 520,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "slavyanskaya.jpg",
                    Name = "Славянская",
                    Description = "Соус \"1000 островов\", Сыр моцарелла, Картофельные дольки, Бекон, Ветчина, Огурцы маринованные, Орегано, Лук маринованныйX, Зелень,",
                    Ingredients = new string[] { "Лук маринованный", "Томаты свежие" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 430,
                    Mass = 560,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "pizza_pear_1.jpg",
                    Name = "Сладкая Италия",
                    Description = "Соус \"Сливочный\", Груша консервированная, Сыр моцарелла, Сыр с голубой плесенью, Орехи грецкие, Мёд натуральный, Орегано",
                    Ingredients = new string[] { },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 510,
                    Mass = 530,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "sliv_ostr.jpg",
                    Name = "Сливочно-острая",
                    Description = "Соус \"1000 островов\", Сыр моцарелла, Сервелат, Бекон, Сливочный сыр, Соус \"Кимчи\", Орегано, Халапеньо,",
                    Ingredients = new string[] { "Томаты" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 430,
                    Mass = 580,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "solanka.jpg",
                    Name = "Солянка",
                    Description = "Соус \"Барбекю\", Сыр моцарелла, Колбаски охотничьи, Бекон, Сервелат, Огурцы маринованные, Лимон, Укроп, Орегано,",
                    Ingredients = new string[] { "Томаты черри", "Лук маринованный", "Маслины" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 450,
                    Mass = 600,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "cheese.jpg",
                    Name = "Сырная",
                    Description = "Сыр моцарелла, Сливочный сыр, Соус \"Кальяри\", Сыр фетаки, Сыр с голубой плесенью, Сыр пармезан, Орегано",
                    Ingredients = new string[] { },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 480,
                    Mass = 550,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "tatar.jpg",
                    Name = "Татарская",
                    Description = "Соус \"Томатный\", Куриный рулет, Сыр моцарелла, Конно-говяжья колбаса, Орегано,",
                    Ingredients = new string[] { "Лук маринованный", "Томаты", "Шампиньоны", "Перец болгарский" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 450,
                    Mass = 580,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "fiesta.jpg",
                    Name = "Фиеста",
                    Description = "Соус \"1000 островов\", Сыр моцарелла, Куриный рулет, Колбаски охотничьи, Сливочный сыр, Сервелат, Опята маринованные, Орегано,",
                    Ingredients = new string[] { "Шампиньоны" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 450,
                    Mass = 580,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "filadelf.jpg",
                    Name = "Филадельфия",
                    Description = "Соус \"Кальяри\", Сыр моцарелла, Лосось, Сливочный сыр, Авокадо, Орегано",
                    Ingredients = new string[] { },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 480,
                    Mass = 510,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "cezar_salmon.jpg",
                    Name = "Цезарь с лососем",
                    Description = "Соус \"Кальяри\", Лосось, Салат айсберг, Соус \"Спайси\", Сыр пармезан",
                    Ingredients = new string[] { "Томаты свежие" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 490,
                    Mass = 550,
                    IsHalf = false,
                    IsAvailableThickness = true
                }
            };
        }

        public IActionResult Index() => View(_list);

        public IActionResult AjaxList() => View();

        public JsonResult GetList() => Json(_list);

    }
}
