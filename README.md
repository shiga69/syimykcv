# Syimyk Zhusupov — CV Site

Персональный сайт-визитка на **Blazor WebAssembly (C#)**. Тёмная тема, анимации
при скролле, переключатель EN/PL, работает **бесплатно и круглосуточно** на
GitHub Pages — без "засыпающего" сервера, так как весь код выполняется в
браузере пользователя.

## 1. Запуск локально (проверить, что всё работает)

Нужен установлен [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
(на твоём ПК с интернатурой он наверняка уже есть).

```bash
cd SyimykCV-site
dotnet restore
dotnet run
```

Открой адрес из консоли (обычно `http://localhost:5000` или `https://localhost:5001`).

## 2. Публикация на GitHub Pages (бесплатно, 24/7)

1. Создай новый репозиторий на GitHub, например `syimyk-cv`.
2. Залей туда содержимое этой папки:

   ```bash
   cd SyimykCV-site
   git init
   git add .
   git commit -m "Initial CV site"
   git branch -M main
   git remote add origin https://github.com/<твой-логин>/syimyk-cv.git
   git push -u origin main
   ```

3. В репозитории на GitHub зайди в **Settings → Pages** →
   в разделе **Build and deployment → Source** выбери **GitHub Actions**.
4. Всё — при каждом `git push` в `main` workflow из `.github/workflows/deploy.yml`
   автоматически соберёт проект и опубликует сайт по адресу:

   ```
   https://<твой-логин>.github.io/syimyk-cv/
   ```

   Первый деплой занимает 1-2 минуты (смотри вкладку **Actions** в репозитории).

Workflow сам подставляет правильный `base href` под имя твоего репозитория —
руками ничего менять не нужно.

## 3. Что можно поменять

- **Тексты/переводы** — `Models/Translations.cs` (отдельно EN и PL).
- **Цвета/анимации** — `wwwroot/css/app.css`, переменные в самом верху файла
  (`--accent`, `--bg` и т.д.) — легко попробовать другой акцентный цвет.
- **Контент секций** — `Pages/Index.razor`.
- **CV-файл для скачивания** — лежит в `wwwroot/files/Syimyk_Zhusupov_CV.pdf`,
  замени на новую версию, когда обновишь резюме.
- **Домен** — если захочешь красивый адрес вместо `github.io`, можно
  подключить свой домен бесплатно через **Settings → Pages → Custom domain**
  (домен покупается отдельно, но подключение к GitHub Pages бесплатное).

## Структура проекта

```
SyimykCV-site/
├── Pages/Index.razor        — вся страница (секции, контент)
├── Layout/MainLayout.razor  — обёртка макета
├── Services/                — сервис переключения языка
├── Models/Translations.cs   — все тексты EN/PL
├── wwwroot/
│   ├── css/app.css          — стили, тема, анимации
│   ├── js/site.js           — scroll-reveal, плавный скролл
│   └── files/               — CV для скачивания
└── .github/workflows/       — автодеплой на GitHub Pages
```
