import React, { useContext, useEffect } from 'react'
import SearchForm from '../../Components/SearchForm'
import Users from '../../Components/Users'
import { AppContext } from '../../Contexts/AppContext'

const SearchPage = () => {
    // const context = useContext(AppContext)
    // useEffect(() => {
    //     context.setUsers([])
    // }, [])
    return (
        <>
            <SearchForm />
            {/* Bir de sonuçları göstermek için bir component tasarlayacağız. */}

            <Users />
        </>
    )
}

export default SearchPage