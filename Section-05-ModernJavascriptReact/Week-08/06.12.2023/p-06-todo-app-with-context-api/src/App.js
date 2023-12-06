import { useEffect, useState } from 'react';
import './App.css';
import TodoWrapper from './Components/TodoWrapper';
import { v4 as uuidv4 } from 'uuid';

// const INITIAL_STATE = [
//   { id: uuidv4(), desc: "aramayı", isComplated: false, isEditing: false },
//   { id: uuidv4(), desc: "sinema", isComplated: false, isEditing: false },
//   { id: uuidv4(), desc: "feyyaz", isComplated: true, isEditing: false },
//   { id: uuidv4(), desc: "gibi", isComplated: false, isEditing: false },
//   { id: uuidv4(), desc: "JavaScript", isComplated: false, isEditing: false },
// ];



function App() {

  return (
    <>
      <TodoWrapper />
    </>
  );
}

export default App;
