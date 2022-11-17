using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestTask.Models;

namespace TestTask.Pages
{
    public class PizzaModel : PageModel
    {
        private readonly List<PizzaDataModel> _pizzaList;
        private string _url = "https://cagliari-pizza.ru/images/dishes/";

        public PizzaModel()
        {
            _pizzaList = new() 
            {
                new()
                {
                    Image = _url + "buritto.jpg",
                    Name = "�������",
                    Description = "���� \"�������� ������\", ��� ���������, ������� ������, ��������, ������ ����������������, ���� ������ \"����������\",",
                    Ingredients = new string[] { "����� ����������", "��� ������������" },
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
                    Name = "�������",
                    Description = "���� \"���������\", ��� ���������, ������� �����, �������� ���������, ���� \"����� - �������\",",
                    Ingredients = new string[] { "������ ������", "��� ������������" },
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
                    Name = "���������",
                    Description = "���� \"�������\", ������� ������, ������� �����, ��� � ������� ��������",
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
                    Name = "�������",
                    Description = "��� ��������� x2, ���� \"1000 ��������\", ���������,",
                    Ingredients = new string[] { "������ ������" },
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
                    Description = "��� ���������, ���� \"�������\", ���� \"�������\", ���������, ����� �����, �����, �������, �������,",
                    Ingredients = new string[] { "������ �����", "����������" },
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
                    Description = "��� ���������, ���� \"1000 ��������\", ������� �����, �������, �������� ���������, �������, �����, ��������, ������ ������������, ",
                    Ingredients = new string[] { "������ �����", "�������", "��� ������������" },
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
                    Name = "4 �����",
                    Description = "���� \"1000 ��������\", ��� ���������, ����� �������, �������, ���������, ��� ��������, �������, ",
                    Ingredients = new string[] { "����������", "������ ������", "�������/������" },
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
                    Name = "��������",
                    Description = "���� \"��������\", ��� ���������, ������� ������, ��������, ������ ������������, �������,",
                    Ingredients = new string[] { "����������", "������ �����", "�������", "��� ������������" },
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
                    Name = "�����ZZ�",
                    Description = "������, ���� \"���������\", ��� ���������, ������, ������� ��������, �����/�������, �������",
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
                    Name = "�������",
                    Description = "���� \"��������\", ��� ���������, �������, �����, ���������, ���� \"�������\", �������,",
                    Ingredients = new string[] { "������", "����� ����������", "��� ������������" },
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
                    Name = "���������",
                    Description = "�������, ���� \"���������\", ��� ���������, ������, �������,",
                    Ingredients = new string[] { "����� ����������" },
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
                    Name = "��������� Premium",
                    Description = "���� \"���������\", ��� ���������, ������, �������, ������� �����, ��������, �������,",
                    Ingredients = new string[] { "����� ����������" },
                    SelectedSize = 0,
                    AvailableSizes = new bool[] { true, true, true },
                    SelectedThiknes = 0,
                    AvailableThickness = new bool[] { true, false },
                    Price = 440,
                    Mass = 590,
                    IsHalf = false,
                    IsAvailableThickness = true
                },
                new()
                {
                    Image = _url + "grek.jpg",
                    Name = "���������",
                    Description = "���� \"�������\", ��� ���������, ��������� ���, ��������, �������,",
                    Ingredients = new string[] { "������ �����", "����� ����������", "�������" },
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
                    Name = "�������",
                    Description = "���� \"�������\", ��� ���������, ��������� ���, ��������, �������,",
                    Ingredients = new string[] { "����������", "��� ������������" },
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
                    Name = "�����������",
                    Description = "���� \"1000 ��������\", ��� ���������, �������, ��������, ������ ������������, ����� ������������, �����, �������,",
                    Ingredients = new string[] { "��� ������������" },
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
                    Name = "��������",
                    Description = "���� \"��������\", ��� ���������, �������, ��������, �������,",
                    Ingredients = new string[] { "������", "����������" },
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
                    Name = "��� �����",
                    Description = "�����, ���� \"�������\", ��� ���������, �������,",
                    Ingredients = new string[] { "������ �����" },
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
                    Name = "������",
                    Description = "���� \"��������\", ��� ���������, �������, ���������, ���� \"�����\", �������, ���������,",
                    Ingredients = new string[] { "������" },
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
                    Name = "�������",
                    Description = "���� \"�������\", �������� ��������, ������� ������, ��� ���������, ������, ���� \"�����\", ������, �������",
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
                    Name = "�����������",
                    Description = "���� \"�������\", ��� ���������, �����, �������� ��������, ��� ��������, �������,",
                    Ingredients = new string[] { "������ �����" },
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
                    Name = "������������",
                    Description = "���� \"1000 ��������\", ��� ���������, �������, �����, �����, �������,",
                    Ingredients = new string[] { "������", "����������", "��� ������������" },
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
                    Name = "�������",
                    Description = "���� \"�������\", ��� ���������, ������, ������� �����, ������, �������",
                    Ingredients = new string[] { "������" },
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
                    Name = "���������",
                    Description = "���� \"��������\", ��� ���������, ��������� ���, �������,",
                    Ingredients = new string[] { "������ �����" },
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
                    Name = "�������",
                    Description = "���� \"�������\", ��� ���������, �������, �������� ��������, �����, ��������, �����, �����, �������,",
                    Ingredients = new string[] { "��� ������������", "�������" },
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
                    Name = "������ �������",
                    Description = "���� \"�������\", ��� ���������, ������� �����, �������, �����, ��������, �������,",
                    Ingredients = new string[] { "������", "����� ����������", "��� ������������", "�������" },
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
                    Name = "���������",
                    Description = "���� \"1000 ��������\", ��� ���������, ��������, �����, �������� ���������, ��������� ���, ��� ��������, �������,",
                    Ingredients = new string[] { "������ �����", "��� ������������", "�������" },
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
                    Name = "���������",
                    Description = "���� \"��������\", ��� ���������, ���������, �������",
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
                    Name = "���������",
                    Description = "���� \"�������\", �������, �������, ��������� ���, ��� ���������, ��� ��������,",
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
                    Name = "��������",
                    Description = "���� \"���������\", ������� �����, ��� ���������, ��������, �������",
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
                    Name = "�����-Cezar",
                    Description = "�������, ������� ������, ���� \"�������\", ��� ���������, ��� ��������, ����� �������, ���� \"������\", �������,",
                    Ingredients = new string[] { "������ �����" },
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
                    Name = "�����-������",
                    Description = "���� \"��������\", ��� ���������, ������� �����, �������, ���� \"������\", ��������, ������, �������,",
                    Ingredients = new string[] { "����� ����������" },
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
                    Name = "��������",
                    Description = "���� \"�������\", ��� ���������, ��������, ��������� ���, �������� ��������, �������,",
                    Ingredients = new string[] { "������ �����" },
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
                    Name = "����������",
                    Description = "���� \"1000 ��������\", ��� ���������, ������������ ������, �����, �������, ������ ������������, �������, ��� ������������X, ������,",
                    Ingredients = new string[] { "��� ������������", "������ ������" },
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
                    Name = "������� ������",
                    Description = "���� \"���������\", ����� ����������������, ��� ���������, ��� � ������� ��������, ����� �������, ̸� �����������, �������",
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
                    Name = "��������-������",
                    Description = "���� \"1000 ��������\", ��� ���������, ��������, �����, ��������� ���, ���� \"�����\", �������, ���������,",
                    Ingredients = new string[] { "������" },
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
                    Name = "�������",
                    Description = "���� \"�������\", ��� ���������, �������� ���������, �����, ��������, ������ ������������, �����, �����, �������,",
                    Ingredients = new string[] { "������ �����", "��� ������������", "�������" },
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
                    Name = "������",
                    Description = "��� ���������, ��������� ���, ���� \"�������\", ��� ������, ��� � ������� ��������, ��� ��������, �������",
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
                    Name = "���������",
                    Description = "���� \"��������\", ������� �����, ��� ���������, �����-������� �������, �������,",
                    Ingredients = new string[] { "��� ������������", "������", "����������", "����� ����������" },
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
                    Name = "������",
                    Description = "���� \"1000 ��������\", ��� ���������, ������� �����, �������� ���������, ��������� ���, ��������, ����� ������������, �������,",
                    Ingredients = new string[] { "����������" },
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
                    Name = "�����������",
                    Description = "���� \"�������\", ��� ���������, ������, ��������� ���, �������, �������",
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
                    Name = "������ � �������",
                    Description = "���� \"�������\", ������, ����� �������, ���� \"������\", ��� ��������",
                    Ingredients = new string[] { "������ ������" },
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

        public List<PizzaDataModel> PizzaList => _pizzaList;

        public void OnGet()
        {

        }
    }
}
