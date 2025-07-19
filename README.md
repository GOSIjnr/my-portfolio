# 🚀 My Portfolio
![.NET 9.0](https://img.shields.io/badge/.NET-9.0-purple)
![License](https://img.shields.io/badge/license-CC-blue)
![GitHub Pages](https://img.shields.io/badge/deploy-GitHub%20Pages-lightgrey)

A **personal portfolio website** to showcase your projects, skills, and experience — built with ❤️ using **Blazor**.

---

## 🌟 Features

* 📱 **Responsive Design** — mobile and desktop friendly
* 🗂️ **Project Showcase** — highlight your key work
* 🙇‍♂️ **About Me** — share your background and passion
* ✉️ **Contact Form** — easy communication interface
* 🎨 **Customizable** — update structure, content, and styles
* 🚀 **CI/CD** — automatic deployment via GitHub Actions + GitHub Pages
* ⚙️ **Deployment Script** — batch file to deploy your source to a target branch

---

## 📷 Screenshots

### 💻 Desktop View

### 📱 Mobile View

> *Homepage preview using the default profile — fully customizable!*

---

## ⚡ Getting Started

### ✅ Prerequisites

📚 **New to Blazor?** Start here: [Introduction to Blazor](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/intro)

* [.NET 9 SDK or later](https://dotnet.microsoft.com/download)

### ▶️ Run Locally

1. Clone the repository:

   ```bash
   git clone <repository-url>
   ```

2. Navigate to the project directory:

   ```bash
   cd my-portfolio
   ```

3. Start the application:

   ```bash
   dotnet run
   ```

4. Open your browser and go to:
   `https://localhost:5001` *(or the URL shown in your terminal)*

---

## 💪 Customization

### ⚒️ YAML Configuration

All site content is managed using **YAML configuration files**. This is the default and recommended method for editing your profile, layout, and settings.

* **`profile.yaml`** — Your personal data (recommended file to edit)
* **`default-profile.yaml`** — Provided as a template fallback
* **`layout.yaml`** — Defines site navigation and section headers

> ⚠️ **Important:** Edits to `layout.yaml` must be made carefully. Mistakes may break navigation or other UI behavior. Ensure you understand the structure in the codebase before editing this file.

Here's an example profile snippet:

```yaml
brand:
  brandDisplayName: "John"
  brandHighlightedDisplayName: "Doe."
  brandRawTargetUrl: "/"

profileImageUrl: "/images/no-image.svg"

socialLinks:
  - iconUrl: "https://api.iconify.design/simple-icons/github.svg"
    title: "GitHub"
    detail: "johndoe"
    linkUrl: "https://github.com/johndoe"
    externalLinkType: 2
```

> 📁 YAML files live under `wwwroot/data/` and can be updated without recompiling the app.

### ✨ YAML Tooling Support

To simplify editing and reduce errors, JSON Schema definitions are included under the `schema/` folder to support modern editors.

#### ✔ VS Code Setup (Recommended)

Enable IntelliSense, auto-completion, and warnings in Visual Studio Code by adding this to `.vscode/settings.json`:

```json
{
  "yaml.schemas": {
    "schema/profile.schema.json": [
      "my-portfolio/wwwroot/data/profile.yaml",
      "my-portfolio/wwwroot/data/default-profile.yaml"
    ],
    "schema/layout.schema.json": "my-portfolio/wwwroot/data/layout.yaml"
  }
}
```

> 💡 Install the [YAML Language Support by Red Hat](https://marketplace.visualstudio.com/items?itemName=redhat.vscode-yaml) extension if not already installed.

#### ⚠ Limitations

Schemas assist with structure and suggestions, but **do not guarantee runtime safety**. Always test your configuration.

#### 🧹 Other Editors

Other editors like JetBrains Rider, Neovim, etc., also support YAML schemas. Refer to their documentation for configuration.

### 🎨 Styling

Customize your site's look in the `wwwroot/css/` folder.
The `app.css` file defines three color variables:

```css
--color-1: black
--color-2: orange
--color-3: white
```

Each variable includes shades from **darkest** to **lightest**. Adjust them to match your personal brand.

---

## 📁 Folder Structure

```
Core/       → Core logic and utilities
Models/     → Application data models
Pages/      → Main pages (Home, Projects, About, etc.)
Services/   → Profile and app-level services
Shared/     → Layout and reusable components
wwwroot/    → Static files (CSS, images, etc.)
```

---

## 📬 Contact Form

The contact form is powered by a backend email relay service.

> 🔒 **Security First**
>
> To protect sensitive keys and credentials, the email logic is handled server-side. This ensures better security and separation of concerns.

To enable or disable email submission, configure the following in `Program.cs`:

```csharp
// ---------- Configurations ----------
builder.Services.Configure<EmailSubmitSettings>(options =>
{
    options.IsEnabled = true;
});
```

If disabled, users will see a toast notification prompting them to use other contact methods.

> 🔧 **Backend Overview**
>
> A small API built with C# runs in a Docker container and is deployed to a platform like Render, Railway, or similar. It accepts form submissions and relays them to an email delivery service (e.g., Resend, SendGrid, Mailgun). The API response follows a standard wrapper format:
>
> ```json
> {
>   "Success": false,
>   "Message": "Too many requests. Please wait before trying again.",
>   "Timestamp": "...",
>   "Data": null
> }
> ```
>
> To prevent spam, it uses frontend honeypots and IP rate limiting with cooldowns.

---

## 🚀 Deployment

This project supports **GitHub Pages** deployment via GitHub Actions.

The deployment workflow is based on [na1307/blazor-github-pages](https://github.com/na1307/blazor-github-pages). Visit the repo to better understand how Blazor WebAssembly works with GitHub Pages and how to configure your own script.

> 🛠️ This setup deploys to the `pages-deploy` branch using a customized workflow.

### 📦 Deployment Steps

1. Fork or clone this repo
2. Adjust the `.github/workflows/deploy.yaml` if needed
3. Push to `main`
4. GitHub Actions will deploy automatically to `pages-deploy`

➡️ Need help? Refer to the [blazor-github-pages repo](https://github.com/na1307/blazor-github-pages).

---

## 🤝 Contributing

Contributions are welcome!
For major changes, please open an issue first to discuss your ideas.

---

## 📿 License

Licensed under the [CC BY-NC 4.0](https://creativecommons.org/licenses/by-nc/4.0/) license.

You may use and modify this project for **personal or non-commercial** use with proper attribution.

**Commercial use is not allowed** without prior permission.
📧 Contact: **[gosijnr7@yahoo.com](mailto:gosijnr7@yahoo.com)**

---

Built with 💻 and fueled by ☕
Thanks for visiting!
