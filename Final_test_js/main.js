let size;

size = Number(window.prompt('Введите размер массива'));
let array_string = [];
for (j = 0; j < size; j++) {
    array_string[j] = (window.prompt(`Введите значения элементов массива x[${j}]`));
}
let i = 0, k = 0;
let new_array_string = [];
sum = 0;
if (size == '') {
    window.alert('Вы не ввели размер массива, попробуйте еще раз !')
} else {
    while (i < size) {
        if (array_string[i].length <= 3) new_array_string[k] = array_string[i];
        i++;
        k++;
    }
    window.alert(`new_array_string = [${new_array_string}]`);
}