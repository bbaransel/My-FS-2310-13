import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import Header from './Components/Header';
import HomePage from './Pages/HomePage/HomePage';
import SearchPage from './Pages/SearchPage/SearchPage';
import Footer from './Pages/Footer/Footer';
import { AppContext } from './Contexts/AppContext';
import { useState } from 'react';
import { Axios } from 'axios';

function App() {
  const [users, setUsers] = useState([]);
  const searchUsers = (keyword) => {
    Axios
      .get('https://api.github.com/users')
      .then((response) => {
        // get isteği tamamladıktan sonra buradaki kodları çalıştır.
      })
  }
  return (
    <>
      <AppContext.Provider>
        <BrowserRouter>
          <Header />
          <Routes>
            <Route path='/' element={<HomePage />} />
            <Route path='/search' element={<SearchPage />} />
          </Routes>
          <Footer />
        </BrowserRouter>
      </AppContext.Provider>
    </>
  );
}

export default App;
