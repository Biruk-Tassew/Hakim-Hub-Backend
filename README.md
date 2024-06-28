# 🌟 HakimHub: Medical Information Recommendation System 🌟

## The Problem

Many individuals in Ethiopia face challenges when seeking medical assistance, such as finding suitable doctors and medical institutions based on their specific needs. The existing process lacks personalized recommendations and a user-friendly interface, leading to inefficiencies and difficulties in accessing quality healthcare services.

## Our Solution

HakimHub is a comprehensive medical information recommendation system designed to address the challenges faced by individuals in Ethiopia. Our platform allows users to input their symptoms and generates personalized recommendations for doctors and medical institutions. With a conversation-based interface, HakimHub understands user input and provides relevant recommendations in a conversational manner.

## Features

### 🔍 User Input Symptom
Users can input their symptoms using text-based input, allowing for a personalized recommendation search. The system asks for additional context or details to improve recommendation accuracy and requests confirmation before fetching recommendations.

### 🏥 Recommendation Display
The system generates a list of recommendations for medical institutions and doctors based on the user's input. Each recommendation includes justification and relevance, sorted by relevance. Clickable buttons/links are provided to access detailed information on the entities.

### 📋 Detailed Information Display
Users can view comprehensive details about doctors and medical institutions by clicking on doctors and institutions for more details and by clicking on buttons in the recommendations. The detailed information includes:
- Name
- Contact Information
- Address
- Specialties
- Qualifications
- Working Hours
- Other relevant information

### 🔍 Search and Filter
HakimHub provides a powerful search and filter functionality, allowing users to easily find doctors and medical institutions based on their specific criteria. The intuitive filtering options enable users to refine their search and quickly access the information they need, enhancing the overall user experience.

## 🚀 Plans

HakimHub aims to become the go-to medical information recommendation system in Ethiopia and expand its services to reach a wider user base. We plan to continuously enhance our platform, gather user feedback, and forge partnerships with healthcare providers to improve the quality and availability of medical services across the country.

---

## Installation

To get started with the backend of HakimHub using .NET 7.0, follow these steps:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/hakimhub-backend.git
   cd hakimhub-backend
   ```

2. **Install .NET 7.0 SDK:**
   Make sure you have the .NET 7.0 SDK installed. You can download it from the official [.NET website](https://dotnet.microsoft.com/download/dotnet/7.0).

3. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

4. **Set up environment variables:**
   Create an `appsettings.json` file in the root directory and add the necessary environment variables:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "your_database_connection_string"
     },
     "AppSettings": {
       "Port": "your_port_number"
     }
   }
   ```

5. **Run the server:**
   ```bash
   dotnet run
   ```

## Usage

Once the server is running, you can start making requests to the backend endpoints. Here are a few example endpoints:

- `POST /api/symptoms`: Submit symptoms to get personalized medical recommendations.
- `GET /api/doctors/:id`: Get detailed information about a specific doctor.
- `GET /api/institutions/:id`: Get detailed information about a specific medical institution.
- `GET /api/search`: Search for doctors and institutions based on criteria.

## Contributing

We welcome contributions to HakimHub! If you have any ideas, suggestions, or bug reports, feel free to open an issue or submit a pull request.

1. Fork the repository.
2. Create your feature branch: `git checkout -b feature/your-feature-name`
3. Commit your changes: `git commit -m 'Add some feature'`
4. Push to the branch: `git push origin feature/your-feature-name`
5. Open a pull request.

---

🌟 **HakimHub** - Your personalized medical assistant in Ethiopia 🌟

---
