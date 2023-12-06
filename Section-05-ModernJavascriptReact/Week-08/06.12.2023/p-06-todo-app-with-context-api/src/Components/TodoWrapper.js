import React, { useEffect, useState } from 'react'
import { TodoContext } from "../Contexts/TodoContext";
import TodoAddForm from './TodoAddForm';
import TodoContainer from './TodoContainer';
import { v4 as uuidv4 } from 'uuid';
import TodoFilter from './TodoFilter';
let tasks = JSON.parse(localStorage.getItem("todo-app-react")) != null ? JSON.parse(localStorage.getItem("todo-app-react")) : []
const TodoWrapper = () => {
    const [taskList, setTaskList] = useState(tasks);
    const [filterMode, setFilterMode] = useState("all");

    // useEffect(
    //     () => {
    //         getLocaleStorage()
    //     }, []);

    useEffect(() => {
        setLocaleStorage()
    }, [taskList])

    const addTask = (_desc) => {
        setTaskList([...taskList, {
            id: uuidv4(),
            desc: _desc,
            isComplated: false,
            isEditing: false,
        }]);
    };
    const toggleComplete = id => {
        setTaskList(
            taskList.map((task) => task.id === id ? { ...task, isComplated: !task.isComplated } : task)
        );
    };

    const deleteTask = id => {
        setTaskList(
            taskList.filter(task => task.id !== id)
        );
    }

    const approval = id => {
        let approval = window.confirm("Emin misiniz?");
        if (approval) deleteTask(id);
    };
    const toggleEditing = id => {
        setTaskList(
            taskList.map((task) => task.id === id ? { ...task, isEditing: true } : { ...task, isEditing: false })
        )
    };

    const updateTask = (id, _desc) => {
        setTaskList(
            taskList.map(task => task.id === id ? { ...task, isEditing: !task.isEditing, desc: _desc } : task)
        )
    };
    const clearAll = () => {
        let approvalClear = window.confirm("Emin misiniz?");
        if (approvalClear) { setTaskList([]) }
    }
    const setLocaleStorage = () => {
        localStorage.setItem("todo-app-react", JSON.stringify(taskList));
    }
    const getLocaleStorage = () => {
        let item = localStorage.getItem("todo-app-react")
        if (item != null) {
            // setTaskList(JSON.parse(item));
            return JSON.parse(item)

        }
    }
    return (
        <TodoContext.Provider value={{ taskList, setTaskList, updateTask, toggleComplete, toggleEditing, deleteTask, approval, addTask, clearAll, filterMode, setFilterMode }}>
            <div className='container p-5 bg-dark-subtle'>
                <TodoAddForm />
                <TodoFilter />
                <TodoContainer />
            </div>
        </TodoContext.Provider>
    )
}

export default TodoWrapper;