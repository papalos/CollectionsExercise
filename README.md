# CollectionsExercise
C#
Задание №8
Массивы, коллекции, исключения

1. Во всех заданиях использовать необходимый тип коллекции класса System.Collections.  
Для демонстрации работы использовать все основные методы и свойства, соответствующего класса. 
Коллекция должна состоять из произвольных значений типа Double.
•	Реализовать массив-список (ArrayList). 
•	Реализовать очередь (Queue). 
•	Реализовать хэш-таблицу (Hashtable). 

2. Для созданной программы с использованием коллекций, реализовать блоки обработки исключений, где это возможно. 
Обработать, как минимум, три различных исключения. При этом  использовать доступные классы исключений, объявленные в System. 
Либо реализовать собственные.

3. Для созданной программы реализовать метод, который использует в качестве аргумента созданный ранее экземпляр коллекций. 
Метод находит среднее арифметическое среди всех значений и обнуляет все элементы коллекции, которые меньше найденного значения. 
Организовать передачу коллекции в метод с использованием модификатора ref.

4.  Используя System.Collections.Stack, написать программу, которая определяет, является ли введенная скобочная структура правильной. 
Примеры правильных скобочных выражений: (), (())(), ()(), ((())), неправильных — )(, ())((), (, )))), ((()).
Методика решения задачи: Рассматриваем последовательно каждый символ заданной величины слева направо. 
Если очередной символ — левая скобка, то размещаем ее в стеке, если правая — то извлекаем элемент из стека 
(это обязательно должна быть левая скобка). После рассмотрения всей строки, если все правильно, стек должен оказаться пустым.

5. Сведения о студентах содержат следующую информацию: фамилия, имя, курс, оценки по предметам (математика, физика, информатика). 
Создать массив записей (из 6-10 элементов) и заполнить его данными.
Найти фамилию и имя студента 2-го курса, который учится хуже остальных. 
Решить эту же задачу с использованием очереди (вместо массива).
