import React, { useState } from 'react'
import TodoForm from './TodoForm';
import { v4 as uuidv4 } from 'uuid';

const TodoWrapper = () => {
    let [todos, setTodos] = useState([]);
    const addTodo = todo => {
        setTodos([...todos, {
            id: uuidv4(),
            desc: todo,
            complated: false
        }])
    };

    return (
        <>
            <div className='TodoWrapper'>
                <h1>FS-231013 Todo App</h1>
                <TodoForm addTodo = {addTodo}/>
            </div>
        </>
    )
}

export default TodoWrapper;