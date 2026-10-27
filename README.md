# KT_Container

# Вариант 1. Контейнер
1) class Container<T> { protected List<T> items = new(); public virtual void Add(T item) => items.Add(item); public int Count => items.Count; }
2) class StringContainer : Container<string> — фиксирует T = string, добавляет метод PrintAllUpper(), выводящий все строки в верхнем регистре.
3) class CountingContainer<T> : Container<T> — оставляет T открытым, переопределяет Add, чтобы вести отдельный счётчик всех добавлений (TotalAdded), помимо обычного Count.
4) Продемонстрируйте StringContainer с несколькими строками и вызовом PrintAllUpper().
5) Продемонстрируйте CountingContainer<int> и CountingContainer<string> — оба должны корректно считать добавления.

# Ограничения
В обоих пунктах с открытым T переопределённый метод должен вызывать базовую реализацию через base.Add(...), а не дублировать её логику добавления в список заново.

# Результаты и проверочные ключи:
<img width="1520" height="257" alt="изображение" src="https://github.com/user-attachments/assets/72105a93-d3a8-4072-9ad4-900d7b234b60" />

# Мои результаты:
<img width="821" height="556" alt="изображение" src="https://github.com/user-attachments/assets/d41e150e-9864-4e6d-ba1b-54525efb8167" />
