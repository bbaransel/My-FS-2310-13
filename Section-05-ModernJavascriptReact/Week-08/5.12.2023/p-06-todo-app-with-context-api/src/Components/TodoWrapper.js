import React, { useState } from 'react'
import { TodoContext } from "../Contexts/TodoContext";
import TodoAddForm from './TodoAddForm';
import TodoContainer from './TodoContainer';
import { v4 as uuidv4 } from 'uuid';
import TodoFilter from './TodoFilter';
const TodoWrapper = ({ tasks }) => {
    const [taskList, setTaskList] = useState(tasks);
    const [filterMode, setFilterMode] = useState("all");

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
    // let state = "all"
    // let oldList = taskList;
    // if (state == "pending") {
    //     oldList = taskList
    //     setTaskList(
    //         taskList.filter(task => task.isComplated === false)
    //     )
    // } else if (state == "complated") {
    //     setTaskList(
    //         taskList.filter(task => task.isComplated === true)
    //     )
    // } else {
    //     setTaskList(taskList = oldList)
    // };

    // const showPending = () => {
    //     state = "pending"
    // }
    // const showComplated = () => {
    //     state = "complated"
    // }
    // const showAll = () => {
    //     state = "all"
    // }
    // showPending, showComplated, showAll
    return (
        <TodoContext.Provider value={{ taskList, setTaskList, updateTask, toggleComplete, toggleEditing, deleteTask, approval, addTask, clearAll, filterMode }}>
            <div className='container p-5 bg-dark-subtle'>
                <TodoAddForm />
                <TodoFilter />

                <TodoContainer />
            </div>
        </TodoContext.Provider>
    )
}

export default TodoWrapper;