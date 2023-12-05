import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'

const Todo = ({ task }) => {
    const context = useContext(TodoContext)
    return (
        <>
            <li className={task.isComplated ? "list-group-item rounded-2 mb-2 text-success text-decoration-line-through d-flex justify-content-between" : "list-group-item rounded-2 mb-2 d-flex justify-content-between"} >
                <div onClick={() => context.toggleComplete(task.id)} className='btn text-start w-75' >{task.desc}</div>
                <div>
                    <button className='btn btn-warning btn-sm m-1' onClick={() => context.toggleEditing(task.id)} ><i class="fa-solid fa-pen-to-square"></i></button>
                    <button className='btn btn-danger btn-sm m-1' onClick={() => context.approval(task.id)}><i class="fa-solid fa-trash"></i></button>
                </div>
            </li>
        </>
    )
}

export default Todo;