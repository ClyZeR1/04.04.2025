# 04.04.2025
# Задача 2.

Составить программу с абстрактным родительским классом и несколькими потомками. Полную структуру классов и их взаимосвязь продумать самостоятельно. Для абстрактного класса определить, какие методы должны быть абстрактными, а какие обычными.

# 1. Создать абстрактный класс Vehicle (транспортное средство). 

# 2. На его основе реализовать классы Car (автомобиль), Bicycle (велосипед) и Lorry (грузовик). Классы должны иметь возможность задавать и получать параметры средств передвижения (цена, максимальная скорость, год выпуска и т.д.). Наряду с общими полями и методами, каждый класс должен содержать и специфичные для него поля, например: в классе Bicycle (велосипед) (поле: количество пассажиров), в классе Car (автомобиль) (поле: мощность автомобиля), в классе Lorry (грузовик) (поле: максимальная ёмкость). 

# 3. Создать класс Garage, содержащий массив/параметризованную коллекцию объектов этих классов в динамической памяти. Предусмотреть возможность в классе Garage ввод полей в списки для каждого производного класса и вывод характеристик объектов каждого списка. 

# 4. Написать демонстрационную программу, в которой будут использоваться все методы классов.
