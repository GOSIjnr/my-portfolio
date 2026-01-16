# 🚀 My Portfolio

![.NET 10.0](https://img.shields.io/badge/.NET-10.0-purple)
![License](https://img.shields.io/badge/license-MIT-blue)
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

<img src="docs/images/home-desktop.png" alt="Desktop Screenshot" width="500"/>

### 📱 Mobile View

<img src="docs/images/home-mobile.png" alt="Mobile Screenshot" width="200"/>


> *Homepage preview using the default profile — fully customizable!*

---

## ⚡ Getting Started

### ✅ Prerequisites

📚 **New to Blazor?** Start here: [Introduction to Blazor](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/intro)

* [.NET 10 SDK or later](https://dotnet.microsoft.com/download)

### ▶️ Run Locally

1. Clone the repository:

   ```bash
   git clone https://github.com/GOSIjnr/my-portfolio.git
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

#### 🩹 Other Editors

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

## 📄 Adding a Resume

You can easily link to your resume from the site.

1. Upload your resume (PDF or DOCX) to **Google Drive**.
2. Copy the **file ID** from the shared URL.
3. Paste the ID into your `profile.yaml` under the `resumeDocID` field:

```yaml
resumeDocID: "your-google-drive-file-id"
```

> 🔇 If no resume ID is provided, the resume button will be visible but non-functional. Consider hiding it with a CSS override.

---

## 📬 Contact Form

The contact form is powered by a backend email relay service.

> 🔐 **Security First**
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
> A small API built with C# runs in a Docker container and is deployed to a platform like **Render**, **Railway**, or other container-friendly services. It accepts form submissions and relays them to an email delivery provider such as **Resend**, **SendGrid**, or **Mailgun**.
>
> To prevent abuse, a honeypot is used on the frontend, and the backend applies IP rate limits and cooldowns.
>
> API responses use a consistent wrapper structure like:
>
> ```json
> {
>   "Success": false,
>   "Message": "Too many requests. Please wait before trying again.",
>   "Timestamp": "...",
>   "Data": null
> }
> ```

---

## 🚀 Deployment

This project supports **GitHub Pages** deployment via GitHub Actions.

The deployment workflow is based on [na1307/blazor-github-pages](https://github.com/na1307/blazor-github-pages). Visit the repo to better understand how Blazor WebAssembly works with GitHub Pages and how to configure your own script.

> 🛠️ This setup deploys to the `pages-deploy` branch using a customized workflow.

### 📦 Deployment Steps

1. Fork or clone this repo
2. Adjust the `.github/workflows/deploy.yaml` if needed
3. Push to `main`
4. GitHub Actions will deploy automatically to `pages-deploy` — only when you push the source code to that branch. A `deploy.bat` script is included under the `.github/workflows/` folder (alongside the deployment YAML) to simplify the process; feel free to review and customize it to fit your workflow.

➡️ Need help? Refer to the [blazor-github-pages repo](https://github.com/na1307/blazor-github-pages).

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

## 🤝 Contributing

Contributions are welcome!
For major changes, please open an issue first to discuss your ideas.

---

Built with 💻 and fueled by ☕
Thanks for visiting!
