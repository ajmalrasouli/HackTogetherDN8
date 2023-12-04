# HackTogetherDN8

![276309148-6b34a40e-27d1-4b6c-8604-f45aceb9877e](https://github.com/ajmalrasouli/HackTogetherDN8/assets/88502375/33400b8c-2fed-4b4d-8479-2c93bcdffda9)


# PasswordStoreApp

Welcome to PasswordStoreApp, a simple ASP.NET Core web application for managing passwords.

## Features

- **Create, Read, Update, Delete (CRUD):** Easily add, view, edit, and delete passwords.
- **Search Functionality:** Search for passwords based on the site name.
- **OpenAI Integration:** Assess password strength and generate strong passwords using OpenAI.

## Getting Started

Follow these steps to get the PasswordStoreApp up and running on your local machine:

1. **Clone the Repository:**
    ```bash
    git clone https://github.com/ajmalrasouli/PasswordStoreApp.git
    cd PasswordStoreApp
    ```

2. **Install Dependencies:**
    ```bash
    dotnet restore
    ```

3. **Update Connection String:**
   - Open `appsettings.json` and update the connection string if necessary.

4. **Run the Application:**
    ```bash
    dotnet run
    ```

5. **Open in Browser:**
   Visit [http://localhost:5000](http://localhost:5000) in your web browser.

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- OpenAI API

NOTE: for the app to work with OpenAI, replace the OPENAI_API_KEY in Details.cshtml file

```c#

async function askOpenAI() {
                    try {
                        // Make an asynchronous request to OpenAI API
                        const response = await fetch("https://api.openai.com/v1/engines/text-davinci-003/completions", {
                            method: "POST",
                            headers: {
                                "Content-Type": "application/json",
                                "Authorization": "Bearer OPENAI_API_KEY",
                            },
                            body: JSON.stringify({
                                prompt: 'Suggest one 8 character length strong passwords',
                            }),
                        });

```


## Acknowledgments

- Grateful acknowledgments to [Microsoft](https://aka.ms/hacktogether/dotnet/) for providing the training and affording us the opportunity to demonstrate our skills.
- Thanks to [OpenAI](https://www.openai.com/) for providing GPT models.


