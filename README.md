# Футбольный тотализатор VBet
## Курсовой проект по дисциплине "Конструироваие программ и языки программирования"

### Основные возможности:
- Возможность делать ставки на текущие футбольные матчи. Поддерживаются следующие соревнования:
  - [Английская Премьер-Лига](https://ru.wikipedia.org/wiki/%D0%90%D0%BD%D0%B3%D0%BB%D0%B8%D0%B9%D1%81%D0%BA%D0%B0%D1%8F_%D0%9F%D1%80%D0%B5%D0%BC%D1%8C%D0%B5%D1%80-%D0%BB%D0%B8%D0%B3%D0%B0)
  - [Испанская Ла Лига](https://ru.wikipedia.org/wiki/%D0%A7%D0%B5%D0%BC%D0%BF%D0%B8%D0%BE%D0%BD%D0%B0%D1%82_%D0%98%D1%81%D0%BF%D0%B0%D0%BD%D0%B8%D0%B8_%D0%BF%D0%BE_%D1%84%D1%83%D1%82%D0%B1%D0%BE%D0%BB%D1%83)
  - [Итальянская Серия А](https://ru.wikipedia.org/wiki/%D0%A7%D0%B5%D0%BC%D0%BF%D0%B8%D0%BE%D0%BD%D0%B0%D1%82_%D0%98%D1%82%D0%B0%D0%BB%D0%B8%D0%B8_%D0%BF%D0%BE_%D1%84%D1%83%D1%82%D0%B1%D0%BE%D0%BB%D1%83_(%D0%A1%D0%B5%D1%80%D0%B8%D1%8F_A))

### Детали реализации:
- Информация о текущих событиях парсится с сайта [Parimatch](https://www.parimatch.by/)
  
### Использованные технологии
- Библиотека [AngleSharp](https://www.google.by/search?q=AngleSharp&oq=AngleSharp&aqs=chrome..69i57j0l5.3046j0j7&sourceid=chrome&ie=UTF-8) для парсинга HTML
- Microsoft SQL Server для работы с базами данных
- Windows Forms для разработки графического интерфейса пользователя
