import React, { useState } from 'react'
import TodoForm from './TodoForm';
import { v4 as uuidv4 } from 'uuid';
import Todo from './Todo';
import TodoContainer from './TodoContainer';

const TodoWrapper = () => {
    let [todos, setTodos] = useState([]);
    const addTodo = todo => {
        setTodos([...todos, {
            id: uuidv4(),
            desc: todo,
            complated: false
        }])
    };

    let toggleComplete = (id) => {
        setTodos(todos.map((todo) => todo.id === id ? { ...todo, complated: !todo.complated } : todo));
    };

    const deleteTask = id => setTodos(todos.filter((todo) => todo.id != id))

    // const deleteTaskAlernative = (id) => {
    //     const newTodos=[];
    //     for(let i = 0; i<todos.length;i++){
    //         if(todos[i]!=id){
    //             newTodos.push(todos[i]);
    //         }
    //     }
    // }

    return (
        <>
            <div className='TodoWrapper'>
                <h1>FS-231013 Todo App</h1>
                <TodoForm addTodo={addTodo} todos={todos} />
                {/* {
                    todos.map((todo) => {
                        return <Todo
                            key={todo.id}
                            task={todo}
                            toggleComplete={toggleComplete}
                        />
                    })
                } */}
                <TodoContainer todos={todos} toggleComplete={toggleComplete} deleteTask={deleteTask}/>
            </div>
        </>
    )
}

export default TodoWrapper;