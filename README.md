# Online Examination Portal – Session Management, Cookies, Filters & Logging in ASP.NET Core MVC

## Project Overview

This project is an ASP.NET Core MVC application developed for an Online Examination Portal.

The application demonstrates the implementation of:

- Session Management
- Cookies
- MVC Filters
- Custom Filters
- Filter Configuration
- Logging Mechanism

The system provides secure access control, remembers user preferences, tracks activities, and applies reusable validation and monitoring logic.

---

# Features Implemented

## 1. Session Management

The application maintains student login sessions using ASP.NET Core Sessions.

### Functionalities
- Stores user login information after successful authentication
- Prevents unauthorized access to protected pages
- Maintains session state during user activity
- Supports automatic session expiration

### Example Usage
- Student logs in
- Session stores username and role
- User can access dashboard until session expires or logout occurs

---

## 2. Cookies Management

Cookies are used to store user preferences.

### Functionalities
- Saves preferred theme
- Saves preferred language
- Automatically loads preferences when user revisits the application

### Example Usage
- User selects Dark Theme
- Theme preference stored in browser cookie
- Theme applied automatically on next visit

---

## 3. Authentication Filter

A custom authentication filter is implemented to verify whether a user is logged in.

### Functionalities
- Checks active session before allowing access
- Redirects unauthenticated users to Login page
- Protects secured controllers and actions

### Protected Areas
- Dashboard
- Examination Panel
- Student Profile

---

## 4. Authorization Filter

Authorization logic restricts access based on user roles.

### Functionalities
- Only Admin users can access admin pages
- Blocks normal users from restricted modules
- Displays unauthorized access message

### Protected Areas
- Admin Panel
- User Management
- System Monitoring

---

## 5. Custom Logging Filter

A reusable logging filter tracks application activities.

### Functionalities
- Logs incoming requests
- Logs controller and action execution
- Records errors and exceptions
- Helps developers troubleshoot issues

### Logged Information
- Request URL
- Action Name
- Timestamp
- Execution Status

---

## 6. Global Filter Configuration

Filters are configured globally for centralized management.

### Benefits
- Reusable security logic
- Cleaner controllers
- Reduced code duplication
- Easier maintenance

---

# User Stories Covered

| User Story ID | Description | Status |
|---|---|---|
| US-201 | Maintain student login sessions | Completed |
| US-202 | Save user preferred theme/language using cookies | Completed |
| US-203 | Block unauthorized users | Completed |
| US-204 | Centralized logging for troubleshooting | Completed |
| US-205 | Reusable filters for security and monitoring | Completed |

---

# Technologies Used

- ASP.NET Core MVC
- C#
- Sessions
- Cookies
- MVC Filters
- Custom Action Filters
- Logging
- Visual Studio

---

# Project Structure

```text
StudentPortalApp
│
├── Controllers
│   └── AccountController.cs
│
├── Filters
│   └── CustomLogFilter.cs
│
├── Views
│   └── Account
│       ├── Login.cshtml
│       └── Dashboard.cshtml
│
├── wwwroot
│
├── appsettings.json
├── Program.cs
└── StudentPortalApp.csproj
```

---

# How the Application Works

## Login Flow
1. User enters login credentials
2. Session is created after successful login
3. Authentication filter validates session
4. Authorized users access protected pages

---

## Preference Flow
1. User selects theme/language
2. Preference stored in cookie
3. Cookie loaded automatically during future visits

---

## Logging Flow
1. Request reaches application
2. Logging filter records request details
3. Action executes
4. Response status logged

---

# Learning Outcomes

Through this project, the following ASP.NET Core MVC concepts are demonstrated:

- Session Handling
- Cookie Management
- Authentication & Authorization
- MVC Filter Pipeline
- Custom Filters
- Logging and Monitoring
- Secure Application Design

---

# Conclusion

This Online Examination Portal demonstrates how ASP.NET Core MVC can be used to build secure and maintainable web applications using sessions, cookies, filters, and centralized logging mechanisms. The project successfully satisfies all required user stories while following reusable and scalable development practices.
