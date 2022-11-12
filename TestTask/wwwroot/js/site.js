var data = [];

const TYPES = {
    THIN: 'THIN',
    FIT: 'FIT'
};

function addData(image, name, description, additional, selection, price, weight, selectedPunkt, type, isCanChange) {
    return {
        image: image,
        name: name,
        description: description,
        additional: additional,
        selection: selection,
        price: price,
        weight: weight,
        selectedPunkt: selectedPunkt,
        type: type,
        isCanChange: isCanChange
    }
}

data.push(addData("xxxl.jpg", "XXXL", "Сыр моцарелла, Соус \"1000 островов\", Куриный рулет, Ветчина, Колбаски охотничьи, Орегано, Бекон, Сервелат, Огурцы маринованные, ", ["Томаты черри", "Лук маринованный", "Маслины"], true, 1600, 345, 1, TYPES.FIT, true));
data.push(addData("4_vkusa.jpg", "4 вкуса", "Соус \"1000 островов\", Сыр моцарелла, Рулет куриный, Ветчина, Пепперони, Сыр пармезан, Орегано, ", ["Шимпиньоны", "Томаты свежие", "Маслины/оливки"], true, 670, 764, 0, TYPES.THIN, false));
data.push(addData("amazonka.jpg", "Амазонка", "Соус \"Томатный\", Сыр моцарелла, Куриная грудка, Брокколи, Огурцы маринованные, Орегано, ", ["Перец болгарский", "Шампиньоны", "Томаты черри", "Маслины", "Лук маринованный"], false, 340, 234, 0, TYPES.THIN, false));
data.push(addData("xxxl.jpg", "БананZZа", "Бананы, Соус \"Гавайский\", Сыр моцарелла, Ананас, Шоколад молочный, Кокос/миндаль, Орегано ", [], true, 1200, 846, 2, TYPES.THIN, false));
data.push(addData("4_vkusa.jpg", "Барбекю", "Соус \"Томатный\", Сыр моцарелла, Ветчина, Бекон, Пепперони, Соус \"Барбекю\", Орегано, ", ["Томаты", "Перец болгарский", "Лук маринованый"], true, 2340, 332, 0, TYPES.FIT, false));
data.push(addData("amazonka.jpg", "Гавайская", "Ветчина, Соус \"Гавайский\", Сыр моцарелла, Ананас, Орегано, ", ["Перец болгарский"], false, 1570, 545, 2, TYPES.FIT, true));
data.push(addData("xxxl.jpg", "Гавайская Premium", "Соус \"Гавайский\", Сыр моцарелла, Ананас, Ветчина, Куриный рулет, Кукуруза, Орегано, ", ["Перец болгарский"], true, 1230, 553, 1, TYPES.THIN, true));
data.push(addData("4_vkusa.jpg", "Греческая", "Соус \"Кальяри\", Сыр моцарелла, Сливочный сыр, Брокколи, Орегано, ", ["Томаты черри", "Перец болгарский", "Маслины"], true, 5320, 565, 0, TYPES.FIT, false));
data.push(addData("amazonka.jpg", "Грибная", "Соус \"Грибной\", Сыр моцарелла, Опята маринованные, Укроп, Орегано, ", ["Шампиньоны", "Лук маринованный"], false, 1160, 313, 0, TYPES.THIN, true));

function buildCard(data_r, iterator) {

    var selection = (data_r.selection) ? `<div class="selection items-2">
                <label class="selection-label">
                    <input ${(data_r.type === TYPES.THIN) ? ' checked' : ''} ${(data_r.isCanChange == true) ? ' disabled' : ' enabled'} class="selection-label-radio" type="radio" name="${iterator * 2 + 1}" />
                    <span class="selection-label-display">Традиционное</span>
                </label class="selection-label">
                <label class="selection-label">
                    <input ${(data_r.type === TYPES.FIT) ? ' checked' : ''} ${(data_r.isCanChange == true) ? ' disabled' : ' enabled'} class="selection-label-radio" type="radio" name="${iterator * 2 + 1}" />
                    <span class="selection-label-display">Толстое</span>
                </label>
            </div>` : '';

    var additional = "";

    for (var i = 0; i < data_r.additional.length; i++) {
        additional = additional + `<label class="products"><input type="checkbox" checked/><span>${data_r.additional[i]}</span></label>${(i === data_r.additional.length - 1) ? ' ' : ', '}`;
    }

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
                ${data_r.description}
                ${additional}
            </article>
        </div>
        <div class="card-row">
            <div class="selection items-3">
                <label class="selection-label">
                    <input ${((data_r.selectedPunkt) === 0) ? 'checked' : ''} class="selection-label-radio" type="radio" name="${iterator * 2}" />
                    <span class="selection-label-display">30 см</span>
                </label>
                <label class="selection-label">
                    <input ${((data_r.selectedPunkt) === 1) ? 'checked' : ''} class="selection-label-radio" type="radio" name="${iterator * 2}" />
                    <span class="selection-label-display">40 см</span>
                </label>
                <label class="selection-label">
                    <input ${((data_r.selectedPunkt) === 2) ? 'checked' : ''} class="selection-label-radio" type="radio" name="${iterator * 2}" />
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
                    <span class="price">${data_r.price}₽</span>
                </div>
                <div class="column">
                    <span class="mass">${data_r.weight}гр</span>
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