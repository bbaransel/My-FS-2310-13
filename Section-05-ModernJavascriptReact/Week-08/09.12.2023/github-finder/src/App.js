import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import Header from './Components/Header';
import HomePage from './Pages/HomePage/HomePage';
import SearchPage from './Pages/SearchPage/SearchPage';
import Footer from './Pages/Footer/Footer';
import { AppContext } from './Contexts/AppContext';
import { useEffect, useState } from 'react';
import Axios from 'axios';
import UserDetailsPage from './Pages/UserDetailsPage/UserDetailsPage';

function App() {
  const token = "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"
  const config = {
    headers: { Authorization: `Bearer ${token}` }
  }
  const [users, setUsers] = useState([]);
  const [user, setUser] = useState({});
  const [userRepos, setUserRepos] = useState([]);
  const searchUsers = (keyword) => {
    Axios
      .get('https://api.github.com/users')
      .then((response) => {
        // get isteği tamamladıktan sonra buradaki kodları çalıştır.
        setUsers(response.data)
      })
  }

  const getUser = (userName) => {
    Axios
      .get(`https://api.github.com/users/${userName}`, config)
      .then((response) => {
        setUser(response.data);
      });
  }
  const getRepos = (userName) => {
    Axios
      .get(`https://api.github.com/users/${userName}/repos`, config)
      .then((response) => {
        setUserRepos(response.data);
      });
  }


  useEffect(() => {
    searchUsers();
  }, [])

  return (
    <>
      <AppContext.Provider value={{ users, getUser, user, userRepos, getRepos }}>
        <BrowserRouter>
          <Header />
          <Routes>
            <Route path='/' element={<HomePage />} />
            <Route path='/search' element={<SearchPage />} />
            <Route path='/getuser/:login' element={<UserDetailsPage />} />
          </Routes>
          <Footer />
        </BrowserRouter>
      </AppContext.Provider>
    </>
  );
}

export default App;
