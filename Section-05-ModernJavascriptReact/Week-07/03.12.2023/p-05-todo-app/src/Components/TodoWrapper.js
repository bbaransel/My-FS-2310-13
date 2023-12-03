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
            complated: false,
            isEditing: false
        }])
    };

    let toggleComplete = (id) => {
        setTodos(todos.map((todo) => todo.id === id ? { ...todo, complated: !todo.complated } : todo));
    };

    const approval = id => {
        let approval = window.confirm("Emin misiniz?");
        if (approval) deleteTask(id);
    };
    const deleteTask = id => setTodos(todos.filter((todo) => todo.id != id));

    const editTodo = id => {
        setTodos(todos.map((todo) => {
            return todo.id == id ? { ...todo, isEditing: !todo.isEditing } : todo
        })
        )
    };
    const saveTodo = (id, value) => {
        setTodos(todos.map((todo) => {
            return todo.id == id ? { ...todo, isEditing: !todo.isEditing, desc: value } : todo
        })
        )
    };

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
                <TodoContainer todos={todos} toggleComplete={toggleComplete} deleteTask={deleteTask} approval={approval} editTodo={editTodo} saveTodo={saveTodo} />
            </div>
        </>
    )
}

export default TodoWrapper;