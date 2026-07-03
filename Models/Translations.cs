namespace SyimykCV.Models;

public static class Translations
{
    public static readonly Dictionary<string, Dictionary<string, string>> Data = new()
    {
        ["en"] = new Dictionary<string, string>
        {
            ["nav.about"] = "About",
            ["nav.skills"] = "Skills",
            ["nav.projects"] = "Projects",
            ["nav.education"] = "Education",
            ["nav.contact"] = "Contact",

            ["hero.role"] = "IT Programming Student",
            ["hero.tagline"] = "Networking · Linux · Cybersecurity Fundamentals",
            ["hero.cta.contact"] = "Get in touch",
            ["hero.cta.cv"] = "Download CV",

            ["about.title"] = "About me",
            ["about.text"] = "Motivated IT Programming student with a strong foundation in networking, Linux administration, and cybersecurity fundamentals. Certified by Cisco Networking Academy and seeking an internship or junior role in Cybersecurity or IT Support.",
            ["about.location"] = "Based in Rzeszów, Poland",

            ["skills.title"] = "Technical skills",

            ["projects.title"] = "Projects",
            ["proj1.title"] = "Network Security Simulation",
            ["proj1.tool"] = "Cisco Packet Tracer",
            ["proj1.p1"] = "Built a small enterprise-style topology (routers/switches/hosts) and validated connectivity using TCP/IP troubleshooting.",
            ["proj1.p2"] = "Configured core services and controls (DHCP/DNS, basic segmentation, ACL-style filtering) to reduce unnecessary exposure.",
            ["proj1.p3"] = "Documented the design, assumptions, and test cases; captured evidence via screenshots/exports for review.",

            ["proj2.title"] = "Phishing & Social Engineering Awareness",
            ["proj2.tool"] = "Security Training Module",
            ["proj2.p1"] = "Created a short awareness module covering common phishing patterns, safe link/attachment handling, and reporting flow.",
            ["proj2.p2"] = "Designed example scenarios and a checklist for emails and messages (sender validation, urgency cues, URL inspection).",
            ["proj2.p3"] = "Summarized outcomes and recommendations in a one-page handout suitable for onboarding/training.",

            ["proj3.title"] = "Linux System Administration Practice",
            ["proj3.tool"] = "Linux Lab Environment",
            ["proj3.p1"] = "Practiced user/group management, permissions, services, and SSH configuration in a Linux lab environment.",
            ["proj3.p2"] = "Applied baseline hardening steps (updates, firewall rules, least-privilege mindset) and validated changes.",
            ["proj3.p3"] = "Performed basic log review and troubleshooting; wrote simple shell commands/scripts to automate repetitive checks.",

            ["education.title"] = "Education",
            ["education.degree"] = "BSc in IT Programming",
            ["education.school"] = "University of Information Technology and Management (WSIiZ), Rzeszów",
            ["education.years"] = "2024 — 2027",
            ["education.coursework"] = "Relevant coursework: Networking (TCP/IP, DNS/DHCP), Linux administration, cybersecurity fundamentals, databases (SQL), programming basics (Python).",

            ["certs.title"] = "Certifications",
            ["cert1"] = "Cybersecurity Essentials",
            ["cert2"] = "Python Essentials",
            ["cert3"] = "Network Support and Security",
            ["certs.issuer"] = "Cisco Networking Academy",

            ["languages.title"] = "Languages",
            ["lang.ru"] = "Russian",
            ["lang.ru.level"] = "Native (C1)",
            ["lang.en"] = "English",
            ["lang.en.level"] = "B1/B2",
            ["lang.pl"] = "Polish",
            ["lang.pl.level"] = "A1/A2",

            ["contact.title"] = "Let's connect",
            ["contact.text"] = "Open to internships and junior roles in Cybersecurity or IT Support.",
            ["contact.email"] = "Email",
            ["contact.phone"] = "Phone",

            ["footer.rights"] = "All rights reserved.",
        },
        ["pl"] = new Dictionary<string, string>
        {
            ["nav.about"] = "O mnie",
            ["nav.skills"] = "Umiejętności",
            ["nav.projects"] = "Projekty",
            ["nav.education"] = "Edukacja",
            ["nav.contact"] = "Kontakt",

            ["hero.role"] = "Student programowania IT",
            ["hero.tagline"] = "Sieci komputerowe · Linux · Podstawy cyberbezpieczeństwa",
            ["hero.cta.contact"] = "Skontaktuj się",
            ["hero.cta.cv"] = "Pobierz CV",

            ["about.title"] = "O mnie",
            ["about.text"] = "Zmotywowany student programowania IT z solidnymi podstawami w sieciach komputerowych, administracji Linux oraz cyberbezpieczeństwie. Posiadam certyfikaty Cisco Networking Academy i poszukuję stażu lub stanowiska juniorskiego w obszarze cyberbezpieczeństwa lub wsparcia IT.",
            ["about.location"] = "Mieszkam w Rzeszowie, Polska",

            ["skills.title"] = "Umiejętności techniczne",

            ["projects.title"] = "Projekty",
            ["proj1.title"] = "Symulacja bezpieczeństwa sieci",
            ["proj1.tool"] = "Cisco Packet Tracer",
            ["proj1.p1"] = "Zbudowałem topologię w stylu małego przedsiębiorstwa (routery/switche/hosty) i zweryfikowałem łączność za pomocą rozwiązywania problemów TCP/IP.",
            ["proj1.p2"] = "Skonfigurowałem podstawowe usługi i mechanizmy kontroli (DHCP/DNS, segmentacja, filtrowanie w stylu ACL), aby ograniczyć niepotrzebną ekspozycję.",
            ["proj1.p3"] = "Udokumentowałem projekt, założenia i przypadki testowe; zebrałem dowody w postaci zrzutów ekranu do przeglądu.",

            ["proj2.title"] = "Świadomość phishingu i socjotechniki",
            ["proj2.tool"] = "Moduł szkoleniowy z bezpieczeństwa",
            ["proj2.p1"] = "Stworzyłem krótki moduł uświadamiający obejmujący typowe wzorce phishingu, bezpieczne obchodzenie się z linkami/załącznikami oraz procedurę zgłaszania.",
            ["proj2.p2"] = "Zaprojektowałem przykładowe scenariusze i listę kontrolną dla e-maili i wiadomości (weryfikacja nadawcy, sygnały pilności, sprawdzanie adresów URL).",
            ["proj2.p3"] = "Podsumowałem wyniki i zalecenia w jednostronicowej ulotce odpowiedniej do wdrażania nowych pracowników/szkoleń.",

            ["proj3.title"] = "Praktyka administracji systemami Linux",
            ["proj3.tool"] = "Środowisko laboratoryjne Linux",
            ["proj3.p1"] = "Ćwiczyłem zarządzanie użytkownikami/grupami, uprawnieniami, usługami oraz konfigurację SSH w środowisku laboratoryjnym Linux.",
            ["proj3.p2"] = "Zastosowałem podstawowe kroki hartowania systemu (aktualizacje, reguły zapory, zasada najmniejszych uprawnień) i zweryfikowałem zmiany.",
            ["proj3.p3"] = "Przeprowadziłem podstawowy przegląd logów i rozwiązywanie problemów; napisałem proste polecenia/skrypty powłoki do automatyzacji powtarzalnych kontroli.",

            ["education.title"] = "Edukacja",
            ["education.degree"] = "Licencjat z Programowania IT",
            ["education.school"] = "Wyższa Szkoła Informatyki i Zarządzania (WSIiZ), Rzeszów",
            ["education.years"] = "2024 — 2027",
            ["education.coursework"] = "Program nauczania: Sieci komputerowe (TCP/IP, DNS/DHCP), administracja Linux, podstawy cyberbezpieczeństwa, bazy danych (SQL), podstawy programowania (Python).",

            ["certs.title"] = "Certyfikaty",
            ["cert1"] = "Cybersecurity Essentials",
            ["cert2"] = "Python Essentials",
            ["cert3"] = "Network Support and Security",
            ["certs.issuer"] = "Cisco Networking Academy",

            ["languages.title"] = "Języki",
            ["lang.ru"] = "Rosyjski",
            ["lang.ru.level"] = "Ojczysty (C1)",
            ["lang.en"] = "Angielski",
            ["lang.en.level"] = "B1/B2",
            ["lang.pl"] = "Polski",
            ["lang.pl.level"] = "A1/A2",

            ["contact.title"] = "Skontaktujmy się",
            ["contact.text"] = "Otwarty na staże i stanowiska juniorskie w obszarze cyberbezpieczeństwa lub wsparcia IT.",
            ["contact.email"] = "Email",
            ["contact.phone"] = "Telefon",

            ["footer.rights"] = "Wszelkie prawa zastrzeżone.",
        },
    };
}
