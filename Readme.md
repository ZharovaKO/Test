# Описание решения, поставленной задачи
Задание звучит следующим образом 
> *Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется  пользоваться коллекциями, лучше обойтись исключительно массивами*

---

Ход решения:
- Было создано два массива. Первый сочитал в себе заначения любой длины, второй для будущего итога
- Затем было создано условие, которое проверяло длину каждого значения в массиве (array[i] <= 3). если условие выполнялось, то значение первого массива заносилось во второй массив
- Чтобы это значение появлялось во втором массиве, была создана переменная **temp**, в которой сохранялось значение и она играла роль индекса. Эта переменная после каждого занесения значения в массив увеличивалась на 1