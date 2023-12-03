import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faPenToSquare, faTrash } from '@fortawesome/free-solid-svg-icons'
import React from 'react'

const Todo = ({ task, toggleComplete, deleteTask, approval, editTodo }) => {
    // console.log(task, toggleComplated)
    return (
        <>
            <div className='Todo'>
                <p onClick={() => { toggleComplete(task.id) }} className={task.complated ? "Complated TodoTask" : "TodoTask"}>
                    {task.desc}
                </p>
                <div className='TodoButtons'>
                    <FontAwesomeIcon onClick={() => { editTodo(task.id) }} icon={faPenToSquare} />
                    <FontAwesomeIcon onClick={() => approval(task.id)} icon={faTrash} />
                </div>
            </div>
        </>
    )
}

export default Todo