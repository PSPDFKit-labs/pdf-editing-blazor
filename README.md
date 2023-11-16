# Blazor PDF Editing with [PDFsharp](https://docs.pdfsharp.net/PDFsharp/Overview/About.html)

This repository contains a Blazor Server application demonstrating the capabilities of editing PDF documents using the PDFsharp library. It offers a basic implementation of how to modify an existing PDF file by adding text, serving as a starting point for more complex PDF manipulation tasks in Blazor applications.

## Features
- Basic PDF editing using PDFsharp.
- Adding text to an existing PDF document.
- Simple Blazor UI for triggering the PDF editing process.

## Getting Started
These instructions will help you get the project up and running on your local machine for development and testing purposes.

## Prerequisites
- .NET 7.0 SDK or later
- Visual Studio 2022 or a compatible IDE
  
## Installation
1. Clone the repository:

```bash
git clone https://github.com/PSPDFKit-labs/pdf-editing-blazor.git
```

2. Open the solution file in Visual Studio.

## Running the Application

1. Build the solution by selecting `Build -> Build Solution`.
2. Run the application by selecting `Debug -> Start Debugging`.
3. Once the application is running, navigate to the main page.
4. Use the provided button to edit the specified PDF file.

## Usage
The application demonstrates basic PDF editing:

- A predefined PDF file ([wwwroot/document.pdf]()) is edited when the user clicks the 'Edit PDF' button.
- The `PdfEditor` class adds specified text to the first page of the PDF.
- Feel free to modify the PDF path and the editing logic in the `PdfEditor` class to explore further functionalities of PDFsharp.

## Contributing
Contributions are welcome! Please feel free to fork the repository and submit pull requests. Please ensure
[you have signed our CLA](https://pspdfkit.com/guides/web/current/miscellaneous/contributing/) so that we can
accept your contributions.


