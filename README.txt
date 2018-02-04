Задача уместить входной текст в строки указанной ширины.

На входе Вы имеете одну строку неограниченной длины и целое значение – ширина одной результирущей строки.

Шрифт моноширинный, то есть все буквы имеют одинаковую ширину.
Правила:

· Используйте пробелы для заполнения промежутков между словами.

· В каждой строчке должно быть наибольшее количество слов.

· Используйте '\n' для переноса строки

· Промежутки между словами не могут отличаться больше чем на один

· '\n' не учитывается при подсчете длинны

· Длинна участков из пробелов в строке должна не возрастать: 'Lorem---ipsum---dolor--sit--amet' (3, 3, 2, 2 пробела).

· Последнюю строку выравнивать не нужно, используйте по одному пробелу между словами.

· Последняя строка не содержит '\n'

· Строки из одного длинного слова не нуждаются в пробелах ('somelongword\n')

· Не используйте перенос слов (слова не разбиваются на части для переноса)

для C# реализуйте следующий класс
public class TextFormatter
{
public string Justify(string text, int width){...}
}
для js - следующую функцию
function justify(text, width) {
}

Дополнительные классы, методы и переменные можно использовать без ограничений.

Пример для width=30:

Lorem ipsum dolor sit amet,

consectetur adipiscing elit.

Vestibulum sagittis dolor

mauris, at elementum ligula

tempor eget. In quis rhoncus

nunc, at aliquet orci. Fusce

at dolor sit amet felis

suscipit tristique. Nam a

imperdiet tellus. Nulla eu

vestibulum urna. Vivamus

tincidunt suscipit enim, nec

ultrices nisi volutpat ac.

Maecenas sit amet lacinia

arcu, non dictum justo. Donec

sed quam vel risus faucibus

euismod. Suspendisse rhoncus

rhoncus felis at fermentum.

Donec lorem magna, ultricies a

nunc sit amet, blandit

fringilla nunc. In vestibulum

velit ac felis rhoncus

pellentesque. Mauris at tellus

enim. Aliquam eleifend tempus

dapibus. Pellentesque commodo,

nisi sit amet hendrerit

fringilla, ante odio porta

lacus, ut elementum justo

nulla et dolor.