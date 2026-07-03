# Syimyk Zhusupov — CV Site

```bash
cd SyimykCV-site
dotnet restore
dotnet run
```


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
