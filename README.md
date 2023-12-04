# HackTogetherDN8

![276309148-6b34a40e-27d1-4b6c-8604-f45aceb9877e](https://github.com/ajmalrasouli/HackTogetherDN8/assets/88502375/33400b8c-2fed-4b4d-8479-2c93bcdffda9)


# PasswordStoreApp 🗃️

Welcome to PasswordStoreApp, a simple ASP.NET Core web application for managing passwords.
**PasswordStoreApp** is a secure and user-friendly password management web application built with **ASP.NET Core**. It empowers users to effortlessly manage their passwords by providing essential features such as Create, Read, Update, and Delete (CRUD) operations. The application includes a robust search functionality, allowing users to easily find passwords associated with specific sites.

## OpenAI Integration 🤖

One of the standout features is the seamless integration with the **OpenAI API**. This integration enhances the application's capabilities by assessing password strength and generating strong passwords. The OpenAI API ensures that users maintain robust and secure credentials for their online accounts.


## Key Features
- **Password Management:** Perform CRUD operations on password entries. Easily add, view, edit, and delete passwords.
- **Search Functionality:** Easily find passwords related to specific sites.
- **Security:** Built on ASP.NET Core, ensuring robust security measures.
- **OpenAI Integration:** Receive password strength suggestions through OpenAI.


Please watch Demo here --> (https://www.youtube.com/watch?v=Mdk3rR7rHP8)

## Getting Started 🔰

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

## Technologies Used 🧰

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


## Sample PasswordStoreApp Pages


### Main page 📄
<img width="1011" alt="1" src="https://github.com/ajmalrasouli/HackTogetherDN8/assets/88502375/fb80d597-1a20-4f2e-b369-9073304fdb83">

### Search page 📄
<img width="1014" alt="2" src="https://github.com/ajmalrasouli/HackTogetherDN8/assets/88502375/cbe45570-4a3e-45db-94d0-8006f6569123">

### Passwords page 📄
<img width="1021" alt="3" src="https://github.com/ajmalrasouli/HackTogetherDN8/assets/88502375/511f6e00-7e9a-434f-bb51-fb2f7ba9e89d">

### Edit page 📄
<img width="1010" alt="4" src="https://github.com/ajmalrasouli/HackTogetherDN8/assets/88502375/ed1be6fc-3a61-4dd2-bd3f-f2f783a99d1a">

### Details page 📄
<img width="1015" alt="5" src="https://github.com/ajmalrasouli/HackTogetherDN8/assets/88502375/3f61bcf7-023a-4c4a-9312-d640991331ca">


<img width="1003" alt="6" src="https://github.com/ajmalrasouli/HackTogetherDN8/assets/88502375/8256877a-7e40-41b0-b697-c9b180ad4fd2">

### User manage page 📄
<img width="1009" alt="7" src="https://github.com/ajmalrasouli/HackTogetherDN8/assets/88502375/765bbbc2-5955-4530-8b2b-d9be7d446ed3">

















