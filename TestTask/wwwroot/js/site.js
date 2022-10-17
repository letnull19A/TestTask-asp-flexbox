var data = [];

function addData(image, name, description, additional, selection) {
    return {
        image: image,
        name: name,
        description: description,
        additional: additional,
        selection: selection
    }
}

data.push(addData("xxxl.jpg", "XXXL", "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные, ", ["Томаты черри", "Лук маринованный", "Маслины"], true));
data.push(addData("4_vkusa.jpg", "4 вкуса", "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные, ", ["Томаты черри", "Лук маринованный", "Маслины"], true));
data.push(addData("amazonka.jpg", "4 вкуса", "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные,", ["Томаты черри", "Лук маринованный", "Маслины"], false));
data.push(addData("xxxl.jpg", "XXXL", "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные, ", ["Томаты черри", "Лук маринованный", "Маслины"], true));
data.push(addData("4_vkusa.jpg", "4 вкуса", "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные, ", ["Томаты черри", "Лук маринованный", "Маслины"], true));
data.push(addData("amazonka.jpg", "4 вкуса", "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные,", ["Томаты черри", "Лук маринованный", "Маслины"], false));
data.push(addData("xxxl.jpg", "XXXL", "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные, ", ["Томаты черри", "Лук маринованный", "Маслины"], true));
data.push(addData("4_vkusa.jpg", "4 вкуса", "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные, ", ["Томаты черри", "Лук маринованный", "Маслины"], true));
data.push(addData("amazonka.jpg", "4 вкуса", "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные,", ["Томаты черри", "Лук маринованный", "Маслины"], false));

function buildCard(data_r, iterator) {

    var selection = (data_r.selection) ? `<div class="selection items-2">
                <label class="selection-label">
                    <input checked class="selection-label-radio" type="radio" name="${iterator * 2 + 1}" />
                    <span class="selection-label-display">Традиционное</span>
                </label class="selection-label">
                <label class="selection-label">
                    <input class="selection-label-radio" type="radio" name="${iterator * 2 + 1}" />
                    <span class="selection-label-display">Толстое</span>
                </label>
            </div>` : '';

    return `
    <div class="card">
        <div class="card-image">
            <img src="https://cagliari-pizza.ru/images/dishes/${data_r.image}" />
        </div>
        <div class="card-name">
            <p>${data_r.name}</p>
        </div>
        <div class="card-description">
            <article>
                Сыр моцарелла, Соус "1000 островов",
                Куриный рулет, Ветчина, Колбаски охотничьи,
                Орегано, Бекон, Сервелат, Огурцы
                маринованные,
                <label class="products"><input type="checkbox" checked/><span>Томаты черри</span></label>,
                <label class="products"><input type="checkbox" checked/><span>Лук маринованный</span></label>,
                <label class="products"><input type="checkbox" checked/><span>Маслины</span></label>
            </article>
        </div>
        <div class="card-row">
            <div class="selection items-3">
                <label class="selection-label">
                    <input checked class="selection-label-radio" type="radio" name="${iterator * 2}" />
                    <span class="selection-label-display">30 см</span>
                </label>
                <label class="selection-label">
                    <input class="selection-label-radio" type="radio" name="${iterator * 2}" />
                    <span class="selection-label-display">40 см</span>
                </label>
                <label class="selection-label">
                    <input class="selection-label-radio" type="radio" name="${iterator * 2}" />
                    <span class="selection-label-display">60 см</span>
                </label>
            </div>
        </div>
        <div class="card-row">
            ${selection}
        </div>
        <div class="card-row">
            <div class="card-price-and-part">
                <div class="column">
                    <span class="price">690₽</span>
                </div>
                <div class="column">
                    <span class="mass">1440гр</span>
                </div>
                <div class="column">
                    <label class="toggler">
                        <input type="checkbox" />
                        <span class="display-checked">1/2</span>
                    </label>
                </div>
            </div>
        </div>
        <div class="card-row">
            <div class="card-in-order">
                <button>В корзину</button>
            </div>
        </div>
    </div>`;
}

function displayData() {
    for (var i = 0; i < data.length; i++) {
        $('#app').append(buildCard(data[i], i));
    }
}

$(document).ready(function () {
    displayData();
});