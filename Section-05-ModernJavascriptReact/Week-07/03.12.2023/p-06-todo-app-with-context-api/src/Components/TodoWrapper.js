import React, { useState } from 'react'
import { TodoContext } from "../Contexts/TodoContext";
import TodoAddForm from './TodoAddForm';
import TodoContainer from './TodoContainer';
import { v4 as uuidv4 } from 'uuid';
const TodoWrapper = ({ tasks }) => {
    const [taskList, setTaskList] = useState(tasks);

    const addTask = (_desc) => {
        setTaskList([...taskList, {
            id: uuidv4(),
            desc: _desc,
            isComplated: false,
            isEditing: false
        }]);
    };
    const toggleComplete = id => {
        setTaskList(
            taskList.map((task) => task.id === id ? { ...task, isComplated: !task.isComplated } : task)
        );

    };

    const deleteTask = id => {
        setTaskList(
            taskList.filter(task => task.id != id)
        );
    }

    const approval = id => {
        let approval = window.confirm("Emin misiniz?");
        if (approval) deleteTask(id);
    };
    const toggleEditing = id => {
        setTaskList(
            taskList.map((task) => task.id === id ? { ...task, isEditing: !task.isEditing } : task)
        )
    };

    const updateTask = (id, _desc) => {
        setTaskList(
            taskList.map(task => task.id === id ? { ...task, isEditing: !task.isEditing, _desc: _desc } : task)
        )
    }
    return (
        <TodoContext.Provider value={{ taskList, setTaskList, updateTask, toggleComplete, toggleEditing, deleteTask, approval, addTask }}>
            <div className='container p-5'>
                <TodoAddForm />
                <TodoContainer />
            </div>
        </TodoContext.Provider>
    )
}

export default TodoWrapper;