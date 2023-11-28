import React from "react"
import "./App.css";
import Header from "./Components/Header/Header.js";
import Content from "./Components/Content/Content.js";
import Footer from "./Components/Footer/Footer.js";

function App() {
    return (
        <div className="App">
            <Header />
            <Content />
            <Footer />
        </div>
    )
};

export default App;