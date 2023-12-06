import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'

const TodoFilter = () => {
    const context = useContext(TodoContext)
    return (
        <>
            <div className='d-flex justify-content-between'>
                <div>
                    <button className='btn btn-primary me-1 ms-1' onClick={() => context.setFilterMode("all")}>All</button>
                    <button className='btn btn-success me-1' onClick={() => context.setFilterMode(true)}>Complated</button>
                    <button className='btn btn-warning' onClick={() => context.setFilterMode(false)}>Pending</button>
                </div>
                <button className='btn btn-danger me-1' type='button' onClick={() => context.clearAll()}>Clear All</button>
            </div>
        </>
    )
}

export default TodoFilter